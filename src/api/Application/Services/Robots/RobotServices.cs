using System.Collections.Generic;
using Api.Infrastructure.Database;
using Api.Ui.Dtos;
using Api.Domain.Models;
using Microsoft.AspNetCore.Mvc;


namespace Api.Application.Services
{
    public class RobotServices : IRobotServices
    {
        private readonly IRobotRepository _repository;

        public RobotServices(IRobotRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Robot> SearchAll(){
            return _repository.GetAllRobots();
        }

        public RobotReadDTO SearchById(int id){

            var robot = _repository.GetRobotById(id);
            RobotReadDTO robotDTO = null;

            if (robot != null){

                robotDTO = new RobotReadDTO(){
                    Id = robot.Id,
                    Code = robot.Code,
                    HP = robot.HP,
                    Name = robot.Name,
                    Picture = robot.Picture
                };

            }

            return robotDTO;

        }

    }
}