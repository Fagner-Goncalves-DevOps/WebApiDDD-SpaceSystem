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
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoaService(IPessoaRepository pessoaRepository,
                             IMapper mapper) 
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;

        }

        //metodos genericos padrão de visualização
        public async Task<IEnumerable<PessoaDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<PessoaDto>>(await _pessoaRepository.ObterTodos()); //usando genericos
        }
        public async Task<PessoaDto> ObterPorId(Guid id)
        {
            return _mapper.Map<PessoaDto>(await _pessoaRepository.ObterPorId(id));

        }

        //metodos genericos padrão de alteração
        public async Task Add(PessoaDto pessoaDto)
        {
            await _pessoaRepository.Adicionar(_mapper.Map<PessoaDto, Pessoa>(pessoaDto));
        }
        public async Task Update(PessoaDto pessoaDto)
        {
          await _pessoaRepository.Atualizar( _mapper.Map<PessoaDto, Pessoa>(pessoaDto));
        }
        public async Task Remove(Guid id)
        {
            await _pessoaRepository.Remover(id);
        }


        //especializados separar eles depois
        public async Task<PessoaEnderecoDto> ObterPessoasEndereco(Guid id)
        {
            return _mapper.Map<PessoaEnderecoDto>(await _pessoaRepository.ObterPessoaEndereco(id));
        }

        public async Task<PessoaContratoEnderecoDto> ObterPessoaContratosEndereco(Guid id)
        {
            return _mapper.Map<PessoaContratoEnderecoDto>(await _pessoaRepository.ObterPessoaContratosEndereco(id));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}




//return await _pessoaRepository.Adicionar(_mapper.Map<PessoaDto, Pessoa>(pessoaDto));

//  await _tabTelecomConsolidadoRepository.Adicionar(_mapper.Map<TabTelecomConsolidadoDto, TabTelecomConsolidado>(tabTelecomConsolidadoDto));
