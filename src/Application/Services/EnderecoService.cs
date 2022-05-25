using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;

        public EnderecoService(IEnderecoRepository enderecoRepository,
                               IMapper mapper)
        {
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EnderecoDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<EnderecoDto>>(await _enderecoRepository.ObterTodos());
        }

        public async Task<EnderecoDto> ObterPorId(Guid id)
        {
            return _mapper.Map<EnderecoDto>(await _enderecoRepository.ObterPorId(id));
        }

        public async Task Add(EnderecoDto contratoDto)
        {
            await _enderecoRepository.Adicionar(_mapper.Map<EnderecoDto, Endereco>(contratoDto));
        }

        public async Task Update(EnderecoDto enderecoDto)
        {
            await _enderecoRepository.Atualizar(_mapper.Map<EnderecoDto, Endereco>(enderecoDto));
        }

        public async Task Remove(Guid id)
        {
            await _enderecoRepository.Remover(id);
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}