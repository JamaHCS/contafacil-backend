using AutoMapper;
using contafacil.back.Application.Features.Employees.Queries.GetEmployees;
using contafacil.back.Application.Features.Positions.Commands.CreatePosition;
using contafacil.back.Application.Features.Positions.Queries.GetPositions;
using contafacil.back.Domain.Entities;

namespace contafacil.back.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }
}