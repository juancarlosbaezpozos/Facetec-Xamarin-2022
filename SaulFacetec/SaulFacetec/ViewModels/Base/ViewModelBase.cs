using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SaulFacetec.ViewModels.Base
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {
        #region Fields & Properties
        private bool _isBusy;
        /// <summary>
        /// 
        /// </summary>
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Initializes the asynchronous.
        /// </summary>
        /// <param name="navigationData">The navigation data.</param>
        /// <returns>Task.</returns>
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
        #endregion
    }
}
