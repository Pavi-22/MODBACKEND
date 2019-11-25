using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using MOD_TechnologyService.Controllers;
using MOD_TechnologyService.Models;
using MOD_TechnologyService.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MOD_Test
{
    public class TechControllerTest
    {
        private readonly Mock<ITechnologyRepository> _repo;
        private readonly TechnologyController _controller;
        public TechControllerTest()
        {
            _repo = new Mock<ITechnologyRepository>();
            _controller = new TechnologyController(_repo.Object);
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetSkills()).Returns(GetTechnologies());
            var result = _controller.Get() as List<Technology>;
            Assert.Equal(3, result.Count);
        }
        /*[Fact]
        public void GetById()
        {
            _repo.Setup(m => m.GetSkillsById("Java")).Returns(GetTechnologies()[0]);
            var result = _controller.Get("Java") as Technology;
            Assert.NotNull(result);
            Assert.Equal("Java", result.SkillName);
        }*/
        [Fact]
        public void Post()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void put()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.DeleteSkills(It.IsAny<int>()));
            var result = _controller.Delete(1) as OkResult;
            Assert.NotNull(result);
        }
        private List<Technology> GetTechnologies()
        {
            return new List<Technology>()
            {
                new Technology() {SkillId = 1,SkillName="Oracle", TOC="str",fee=200,Duration=2},
                new Technology() {SkillId = 2,SkillName="Oracle2"},
                new Technology() {SkillId = 3,SkillName="Oracle3"}
            };
        }
    }
}
