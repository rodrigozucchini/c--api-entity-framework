using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;
using TodoApi.Repositories;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IRepository<Producto> _repository;

        public ProductosController(IRepository<Producto> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            var productos = await _repository.GetAllAsync();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            try
            {
                var producto = await _repository.GetByIdAsync(id);
                return Ok(producto);
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"Producto con ID {id} no encontrado.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> PostProducto(Producto producto)
        {
            var createdProducto = await _repository.CreateAsync(producto);
            return CreatedAtAction(nameof(GetProducto), new { id = createdProducto.Id }, createdProducto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, Producto producto)
        {
            if (id != producto.Id) return BadRequest();
            await _repository.UpdateAsync(id, producto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
