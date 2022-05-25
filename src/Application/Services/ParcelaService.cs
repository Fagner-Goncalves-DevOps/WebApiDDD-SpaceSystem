 using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services
{
    public class ParcelaService : IParcelaService
    {
        private readonly IParcelaRepository _parcelaRepository;
        private readonly IMapper _mapper;

        public ParcelaService(IParcelaRepository parcelaRepository,
                             IMapper mapper) 
        {
            _parcelaRepository = parcelaRepository;
            _mapper = mapper;

        }

        //metodos genericos padrão de visualização
        public async Task<IEnumerable<ParcelaDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<ParcelaDto>>(await _parcelaRepository.ObterTodos()); //usando genericos
        }
        public async Task<ParcelaDto> ObterPorId(Guid id)
        {
            return _mapper.Map<ParcelaDto>(await _parcelaRepository.ObterPorId(id));

        }

        //metodos genericos padrão de alteração
        public async Task Add(ParcelaDto parcelaDto)
        {
            await _parcelaRepository.Adicionar(_mapper.Map<ParcelaDto, Parcela>(parcelaDto));
        }
        public async Task Update(ParcelaDto parcelaDto)
        {
          await _parcelaRepository.Atualizar( _mapper.Map<ParcelaDto, Parcela>(parcelaDto));
        }
        public async Task Remove(Guid id)
        {
            await _parcelaRepository.Remover(id);
        }



        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}




//return await _pessoaRepository.Adicionar(_mapper.Map<PessoaDto, Pessoa>(pessoaDto));

//  await _tabTelecomConsolidadoRepository.Adicionar(_mapper.Map<TabTelecomConsolidadoDto, TabTelecomConsolidado>(tabTelecomConsolidadoDto));
