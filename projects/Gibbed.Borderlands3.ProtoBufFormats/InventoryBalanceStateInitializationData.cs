/* Copyright (c) 2019 Rick (rick 'at' gibbed 'dot' us)
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 *
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 *
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System.Collections.Generic;
using System.ComponentModel;
using ProtoBuf;

namespace Gibbed.Borderlands3.ProtoBufFormats
{
    [ProtoContract]
    public class InventoryBalanceStateInitializationData : INotifyPropertyChanged
    {
        #region Fields
        private int _GameStage;
        private string _Inventory;
        private string _InventoryBalance;
        private string _Manufacturer;
        private List<string> _Parts;
        private List<string> _GenericParts;
        private byte[] _AdditionalData;
        private List<string> _CustomizationParts;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public int GameStage
        {
            get { return this._GameStage; }
            set
            {
                if (value != this._GameStage)
                {
                    this._GameStage = value;
                    this.NotifyOfPropertyChange(nameof(GameStage));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public string Inventory
        {
            get { return this._Inventory; }
            set
            {
                if (value != this._Inventory)
                {
                    this._Inventory = value;
                    this.NotifyOfPropertyChange(nameof(Inventory));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public string InventoryBalance
        {
            get { return this._InventoryBalance; }
            set
            {
                if (value != this._InventoryBalance)
                {
                    this._InventoryBalance = value;
                    this.NotifyOfPropertyChange(nameof(InventoryBalance));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public string Manufacturer
        {
            get { return this._Manufacturer; }
            set
            {
                if (value != this._Manufacturer)
                {
                    this._Manufacturer = value;
                    this.NotifyOfPropertyChange(nameof(Manufacturer));
                }
            }
        }

        [ProtoMember(5, IsRequired = true)]
        public List<string> Parts
        {
            get { return this._Parts; }
            set
            {
                if (value != this._Parts)
                {
                    this._Parts = value;
                    this.NotifyOfPropertyChange(nameof(Parts));
                }
            }
        }

        [ProtoMember(6, IsRequired = true)]
        public List<string> GenericParts
        {
            get { return this._GenericParts; }
            set
            {
                if (value != this._GenericParts)
                {
                    this._GenericParts = value;
                    this.NotifyOfPropertyChange(nameof(GenericParts));
                }
            }
        }

        [ProtoMember(7, IsRequired = false)]
        public byte[] AdditionalData
        {
            get { return this._AdditionalData; }
            set
            {
                if (value != this._AdditionalData)
                {
                    this._AdditionalData = value;
                    this.NotifyOfPropertyChange(nameof(AdditionalData));
                }
            }
        }

        [ProtoMember(8, IsRequired = true)]
        public List<string> CustomizationParts
        {
            get { return this._CustomizationParts; }
            set
            {
                if (value != this._CustomizationParts)
                {
                    this._CustomizationParts = value;
                    this.NotifyOfPropertyChange(nameof(CustomizationParts));
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
