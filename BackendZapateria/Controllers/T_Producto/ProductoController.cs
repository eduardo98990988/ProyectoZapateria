using AutoMapper;
using Bussniess.T_Producto;
using DBModelZapateria;
using IBussniess.T_Producto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestRespons.Request.T_Producto;
using RequestRespons.Response.T_Producto;
using RequestResponse.Request;
using RequestResponse.Response;
using System.Net;

namespace BackendZapateria.Controllers.T_Producto
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        #region Declaracion de Variables
        private readonly IProductoBussniess _ProductoBussniess;
        private readonly IMapper _mapper;

        public ProductoController(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoBussniess = new ProductoBussniess(mapper);

        }
        #endregion Declaracion de Variables
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ProductoBussniess.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetDetalleProducto(int id)
        {
            return Ok(_ProductoBussniess.GetDetalleProducto(id));
        }
        [HttpPost]
        public IActionResult Create([FromBody] RequestProducto entity)
        {
            return Ok(_ProductoBussniess.Create(entity));
        }
        [HttpPost("filter")]
        public IActionResult GetBYFilter([FromBody] RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseVProducto> filterProducto = _ProductoBussniess.GetByFilter(request);
            return Ok(filterProducto);
        }
        [HttpPut]
        public IActionResult Update([FromBody] RequestProducto entity)
        {
            return Ok(_ProductoBussniess.Update(entity));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_ProductoBussniess.Delete(id));

        }

        #region Subido de Imagen A la Web 
            //private readonly IArchivosNegocio<RequestProducto, ResponseVProducto> _prone;
            //public ArchivosController(IMapper mapper)
            //{
            //    _mapper = mapper;
            //    _prone = new ArchivosNegocio(mapper);

            //}
            //[HttpPost]
            //public ActionResult UploadFile(IFormFile file, int id)
            //{
            //    return Ok(_prone.UploadFiled(file, id));
            //}
            //public interface IArchivosNegocio<T, Y> : IDisposable
            //{
            //    Y Update(T entity);

            //    public Task UploadFiled(IFormFile file, int id);
            //}

            //public class ArchivosNegocio : IArchivosNegocio<ProductoRequest, ProductoResponse>
            //{
            //    private readonly IArchivosRepositorio<Producto> _Repositorio;
            //    private readonly IMapper _mapper;
            //public ArchivosNegocio(IMapper mapper)
            //{
            //    _mapper = mapper;
            //    _Repositorio = new ArchivosRepositorio();
            //}
            //    public void Dispose()
            //{
            //    GC.SuppressFinalize(this);
            //}

            //public ProductoResponse Update(ProductoRequest dato)
            //{
            //    Producto per = _Repositorio.GetById(dato.IdProducto);

            //    if (per == null)
            //    {
            //        throw new Exception("El producto con el ID especificado no se encontró.");
            //    }

            //    if (!string.IsNullOrEmpty(dato.Imagen))
            //    {
            //        per.Imagen = dato.Imagen;
            //    }

            //    per = _Repositorio.Update(per);

            //    ProductoResponse r = _mapper.Map<ProductoResponse>(per);
            //    return r;
            //}

            //public Task UploadFiled(IFormFile file, int id)
            //{

            //    if (file != null && file.Length > 0)
            //    {
            //        string fileName = Path.GetFileName(file.FileName);
            //        using (var stream = file.OpenReadStream())
            //        {
            //            UploadToFTP(stream, fileName);
            //        }

            //        string ftpUrl = $"ftp://198.37.116.25/www.Komparadm.somee.com/imagenangular/{fileName}";

            //        string message = "archivo subido correctamente";
            //        Console.WriteLine(message);

            //        UpdateTable(id, fileName);
            //    }
            //    else
            //    {
            //        string message = "ocurrrio un error";
            //        Console.WriteLine(message);
            //    }
            //    return Task.CompletedTask;
            //}
            //private void UploadToFTP(Stream fileStream, string fileName)
            //{
            //    string ftpServerIP = "123.134.343";
            //    string ftpUsername = "jnameservere";
            //    string ftpPassword = "Password";

            //    try
            //    {
            //        using (var client = new WebClient())
            //        {
            //            client.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
            //            client.UploadData($"ftp://{ftpServerIP}/www.Komparadm.somee.com/imagenangular/{fileName}", ReadFully(fileStream));
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new Exception($"Error al cargar el archivo al servidor FTP: {ex.Message}");
            //    }
            //}

            //private byte[] ReadFully(Stream input)
            //{
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        input.CopyTo(ms);
            //        return ms.ToArray();
            //    }
            //}

            //    private void UpdateTable(int id, string imagen)
            //{
            //    //primero debo crear el modelo a usar //
            //    ProductoRequest datos = new ProductoRequest();
            //    datos.IdProducto = id;
            //    datos.IdCategoria = 0;
            //    datos.IdSubcategoria = 0;
            //    datos.Nombre = "";
            //    datos.Descripcion = "";
            //    datos.Imagen = "https://komparadm.somee.com/imagenangular/" + imagen;
            //    datos.Precio = 0;
            //    datos.Estado = true;

            //    Update(datos);
            //}
         #endregion Fin De Subida a la Pagina
        }

}
