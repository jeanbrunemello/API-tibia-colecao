using ApiTibiaColecao.Database;
using ApiTibiaColecao.Dto;
using ApiTibiaColecao.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiTibiaColecao.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ItemApi : ControllerBase
    {

        private ItemContext ControllerContext;
        private IMapper ControllerAutoMapper;

        public ItemApi(ItemContext context, IMapper AutoMapper)
        {
            ControllerContext = context;
            ControllerAutoMapper = AutoMapper;
        }

        [HttpPost]
        public CreatedAtActionResult CreateItem([FromBody] CreateItemDto itemDto) 
        {
            Item itemCriado = ControllerAutoMapper.Map<Item>(itemDto);
            ControllerContext.Add(itemCriado);
            ControllerContext.SaveChanges();
            return CreatedAtAction(nameof(GetItemById), new { id = itemCriado.Id }, itemCriado);

        }

        [HttpGet]
        public IEnumerable<GetItemDto> GetAllItems([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return ControllerAutoMapper.Map<List<GetItemDto>>(ControllerContext.Items.Skip(skip).Take(take));
        }

        [HttpGet("itemName/{nomeBuscado}")]
        public IActionResult GetItemByName(string nomeBuscado)
        {
            var item = ControllerContext.Items.FirstOrDefault(itemBuscado => itemBuscado.nome.Equals(nomeBuscado));
            if (item == null) return NotFound();

            var itemDto = ControllerAutoMapper.Map<GetItemDto>(item);
            return Ok(itemDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetItemById(int id)
        {
            var item = ControllerContext.Items.FirstOrDefault(itemBuscado => itemBuscado.Id == id);
            if(item == null) return NotFound();

            var itemDto = ControllerAutoMapper.Map<GetItemDto>(item);
            return Ok(itemDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateItem(int id, [FromBody] UpdateItemDto itemDto)
        {
            var item = ControllerContext.Items.FirstOrDefault(itemBuscado=> itemBuscado.Id == id);
            if (item == null) return NotFound();

            ControllerAutoMapper.Map(itemDto, item);
            ControllerContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = ControllerContext.Items.FirstOrDefault(itemBuscado=> itemBuscado.Id == id);
            if (item == null) return NotFound();
            ControllerContext.Remove(item);
            ControllerContext.SaveChanges();
            return NoContent();
        }


    }
}
