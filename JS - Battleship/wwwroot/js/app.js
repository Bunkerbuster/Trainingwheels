﻿document.addEventListener('DOMContentLoaded', () => {
    const UserGrid = document.querySelector('.grid-user');
    const ComputerGrid = document.querySelector('.grid-computer');
    const DisplayGrid = document.querySelector('.grid-display');

    const Ships = document.querySelectorAll('.ship');
    const Destroyer = document.querySelector('.destroyer-container');
    const Submarine = document.querySelector('.submarine-container');
    const Cruiser = document.querySelector('.cruiser-container');
    const Battleship = document.querySelector('.battleship-container');
    const Carrier = document.querySelector('.carrier-container');

    const StartButton = document.querySelector('#start');
    const RotateButton = document.querySelector('#rotate');
    const TurnDisplay = document.querySelector('#whose-go');
    const InfoDisplay = document.querySelector('#info');

    const userSquares = []
    const ComputerSquares = []
    const width = 10;

    // Create Board
    function CreateBoard(grid, squares) {
        for (let i = 0; i < width * width; i++) {
            const square = document.createElement('div')

            square.dataset.id = i

            grid.appendChild(square);
            squares.push(square);
        }

    }
    CreateBoard(UserGrid, userSquares);
    CreateBoard(ComputerGrid, ComputerSquares);
    //CreateBoard(ComputerGrid, UserSquares, width);
    ////////////////////////////////////////////////
    ////////////////////////////////////////////////
})
