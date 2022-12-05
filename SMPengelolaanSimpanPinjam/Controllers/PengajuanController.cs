﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repositories.Data;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PengajuanController : ControllerBase
    {
        private readonly PengajuanRepository _repository;
        public IConfiguration _configuration;
        public PengajuanController(PengajuanRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        [HttpGet("DaftarPengajuanAnggota")]
        public ActionResult GetDaftarPengajuanAnggota(int idUser)
        {
            try
            {
                var data = _repository.GetDaftarPengajuanAnggota(idUser);
                if (data == null)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data not found"
                    }); ;
                }
                else
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data has been retrieved",
                        Data = data
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            try
            {
                var data = _repository.GetAll();
                if (data == null)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data not found"
                    }); ;
                }
                else
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data has been retrieved",
                        Data = data
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("JenisPinjaman")]
        public ActionResult GetJenisPinjaman(int idJenisPinjaman)
        {
            try
            {
                var data = _repository.GetJenisPinjaman(idJenisPinjaman);
                if (data == null)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data not found"
                    }); ;
                }
                else
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data has been retrieved",
                        Data = data
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }

        [HttpPost("TambahPengajuan")]
        public ActionResult TambahPengajuanBaru(Pengajuan pengajuan)
        {
            try
            {
                var data = _repository.TambahPengajuanBaru(pengajuan);
                if (data == 0)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data failed to save"
                    });
                }
                else if (data == 2)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Anda belum layak melakukan pengajuan"
                    });
                }
                else
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Sukses melakukan pengajuan"
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }


        [HttpPost("ProsesPengajuan")]
        public ActionResult ProsesPengajuan(int idPengajuan, bool terimaPengajuan)
        {
            try
            {
                var data = _repository.ProsesPengajuan(idPengajuan, terimaPengajuan);
                if (data == 0)
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Data failed to save"
                    });
                }
                else
                {
                    return Ok(new
                    {
                        StatusCode = 200,
                        Message = "Sukses memproses pengajuan"
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }


    }
}