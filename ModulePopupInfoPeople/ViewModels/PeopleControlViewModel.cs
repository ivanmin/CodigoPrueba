using System.Collections.Generic;
using System.Windows.Documents;
using API.Data;
using API.Services;
using Model;
using Prism.Commands;
using Prism.Mvvm;

namespace ModulePopupInfoPeople.ViewModels
{
    public class PeopleControlViewModel: BindableBase
    {
        private IInformationService _service;
        public PeopleControlViewModel(IInformationService service)
        {
            _service = service;
        }

        private string _text = "Prueba Command Binding";
        public string Texto
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        //TODO CREAR UN COMMAND Bindeado al FetchButton de la vista PeopleControl
        //que rellene la lista de la vista
        //Crear la propiedad a bindear a la vista para mostrar la lista de people que devuelve el IPeopleProvider
        public DelegateCommand GetDataCommand
        {
            get
            {
                return null;
                
            }
        }


       



    }
}
