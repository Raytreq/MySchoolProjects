using JokesAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace JokesAPI.Services
{
    public interface IService
    {
        Task<List<JokeClass>> GetJokesAsync();
    }
}
