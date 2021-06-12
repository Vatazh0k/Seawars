using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Seawars.Domain.Models;
using Seawars.Infrastructure.Data;
using Seawars.Infrastructure.Extentions;
using Seawars.Interfaces.Game;
using Seawars.WPF.Common;
using Seawars.WPF.Common.Commands.Base;
using Seawars.WPF.Common.Data;
using Seawars.WPF.Interfaces;
using Seawars.WPF.Model;
using Seawars.WPF.Services;

namespace Seawars.WPF.ViewModels
{
    public class BattleGroundDataWithComputerViewModel : ViewModelBase, IBattleGroundData
    {
        #region Data
        private string _attackHint = "";
        private int _enemyShipsCount = 10;
        private int _missCounter = 0;

        private bool isComputerMove = default;
        private bool IsGameOver = default;

        private EnemyFieldViewModel Enemy;
        private UserFieldPageViewModel User;

        public string AttackHint
        {
            get => _attackHint;
            set => Set(ref _attackHint, value);
        }

        public int EnemyShipsCount
        {
            get => _enemyShipsCount;
            set => Set(ref _enemyShipsCount, value);
        }

        public int MissCounter
        {
            get => _missCounter;
            set => Set(ref _missCounter, value);
        }
        #endregion

        public ICommand AttackCommand { get; set; }


        public BattleGroundDataWithComputerViewModel()
        {
            AttackCommand = new Command(AttackCommandAction, CanUseAttackCommand);

            Enemy = ServicesLocator.EnemyFieldViewModel;
            User = ServicesLocator.UserFieldPageViewModel;
        }

        private bool CanUseAttackCommand(object arg) => !isComputerMove && !IsGameOver;


        private void AttackCommandAction(object obj)
        {
            throw new NotImplementedException();
        }

    }
}
