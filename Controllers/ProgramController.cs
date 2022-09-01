using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TicTacToe.Models;

namespace TicTacToe.Controllers;

class Program
{
    private readonly ILogger<ProgramController> _logger;
    
    public ProgramController(ILogger<ProgramController> logger)
    {
        _logger = logger;
    }

}
