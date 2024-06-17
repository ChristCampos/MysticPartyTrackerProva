using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class SpellsViewModel : ObservableObject
    {
        public SpellsViewModel()
        {
            CriarMagiaCommand = new Command(CriarMagia);
        }

        [ObservableProperty]
        private string _magia;

        [ObservableProperty]
        private string _tipo;

        [ObservableProperty]
        private int _dano;

        private ObservableCollection<Spells> _spells = new ObservableCollection<Spells>();
        public ObservableCollection<Spells> Spells
        {
            get { return _spells; }
            set { _spells = value; }
        }

        public ICommand CriarMagiaCommand { get; }

        public void CriarMagia()
        {
            _spells.Add(new Spells(Magia, Tipo, Dano));
        }
    }
}
