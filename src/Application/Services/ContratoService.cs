using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Generics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ContratoService : IContratoService
    {
        private readonly IContratoRepository _contratoRepository;
        private readonly IMapper _mapper;

        public ContratoService(IContratoRepository pessoaRepository,
                               IMapper mapper) 
        {
            _contratoRepository = pessoaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ContratoDto>> GetAll()
        {
            return _mapper.Map<IEnumerable< ContratoDto >> (await _contratoRepository.ObterTodos());
        }

        public async  Task<ContratoDto> ObterPorId(Guid id)
        {
            return _mapper.Map<ContratoDto>(await _contratoRepository.ObterPorId(id));
        }

        public async Task Add(ContratoDto contratoDto)
        {
             await _contratoRepository.Adicionar(_mapper.Map<ContratoDto, Contrato>(contratoDto));
        }

        public async Task Update(ContratoDto contratoDto)
        {
            await _contratoRepository.Atualizar(_mapper.Map<ContratoDto, Contrato>(contratoDto));
        }

        public async Task Remove(Guid id)
        {
            await _contratoRepository.Remover(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
