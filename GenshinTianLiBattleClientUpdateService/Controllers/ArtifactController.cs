using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GenshinTianLiBattleClientUpdateService.Data;
using GenshinTianLiBattleClientUpdateService.Models;

namespace GenshinTianLiBattleClientUpdateService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArtifactController : ControllerBase
    {
        private readonly ArtifactContext _context;

        public ArtifactController(ArtifactContext context)
        {
            _context = context;
        }

        // GET: Artifact/Version/Latest
        [HttpGet]
        [Route("Version/Latest")]
        public IActionResult GetLatestVersion()
        {
            // 获取最新的
            var latestVersion = _context.Artifacts.OrderByDescending(a => a.UpdateTime).FirstOrDefault();
            if (latestVersion == null)
            {
                return NotFound();
            }
            return Ok(latestVersion.Version);
        }
        // GET: Artifact/Version/DownloadUrl
        [HttpGet]
        [Route("Version/DownloadUrl/{version}")]
        public IActionResult GetDownloadUrl(string version)
        {
            // 获取对应版本下载链接
            var artifact = _context.Artifacts
                .Where(a => a.Version == version)
                .OrderByDescending(a => a.UpdateTime)
                .FirstOrDefault();

            if (artifact == null)
            {
                return NotFound();
            }
            return Ok(artifact.DownloadUrl);
        }

        // GET: Artifact/Version/DownloadUrlAndHash
        [HttpGet]
        [Route("Version/DownloadUrlAndHash/{version}")]
        public IActionResult GetDownloadUrlAndHash(string version)
        {
            // 获取对应版本下载链接
            var artifact = _context.Artifacts
                .Where(a => a.Version == version)
                .OrderByDescending(a => a.UpdateTime)
                .FirstOrDefault();

            if (artifact == null)
            {
                return NotFound();
            }

            return Ok(artifact.Hash + "|"+ artifact.DownloadUrl);
        }

        // POST: Artifact
        [HttpPost]
        public async Task<ActionResult<Artifact>> PostArtifact(Artifact artifact, string token)
        {
            if (_context.Tokens.Where(t => t.TokenString == token).FirstOrDefault() == null)
            {
                Console.WriteLine("token:" + token);
                return Unauthorized();
            }

            artifact.Id = Guid.NewGuid();
            artifact.UpdateTime = DateTime.Now;
            _context.Artifacts.Add(artifact);
            await _context.SaveChangesAsync();
            return Ok(artifact.Version);
        }

    }
}
