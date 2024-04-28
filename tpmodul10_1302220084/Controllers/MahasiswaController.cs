using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace tpmodul10_1302220084.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static readonly List<Mahasiswa> DaftarMahasiswa =
        [
            new Mahasiswa("Febry Twenido Firmanio", "1302220084"),
            new Mahasiswa("Indra Mahesa", "1302220067"),
            new Mahasiswa("Henri Silas Samban", "1302220087"),
            new Mahasiswa("Asyifa Ekhar Nanda Kautsar", "1302223029"),
            new Mahasiswa("Fionadhilla Gustriani", "1302220002"),
        ];

        [HttpGet()]
        public IEnumerable<Mahasiswa> Get()
        {
            return DaftarMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return DaftarMahasiswa[id];
        }

        [HttpPost()]
        public void Post(Mahasiswa mahasiswa)
        {
            DaftarMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DaftarMahasiswa.Remove(DaftarMahasiswa[id]);
        }
    }
}
