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

using System.ComponentModel;
using ProtoBuf;

namespace Gibbed.Borderlands3.ProtoBufFormats
{
    [ProtoContract]
    public class InventoryItemData : INotifyPropertyChanged
    {
        #region Fields
        private byte[] _SerialNumber;
        private int _PickupOrderIndex;
        private int _Flags;
        private string _WeaponSkin;
        private InventoryBalanceStateInitializationData _DevelopmentSaveData;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public byte[] SerialNumber
        {
            get { return this._SerialNumber; }
            set
            {
                if (value != this._SerialNumber)
                {
                    this._SerialNumber = value;
                    this.NotifyOfPropertyChange(nameof(SerialNumber));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public int PickupOrderIndex
        {
            get { return this._PickupOrderIndex; }
            set
            {
                if (value != this._PickupOrderIndex)
                {
                    this._PickupOrderIndex = value;
                    this.NotifyOfPropertyChange(nameof(PickupOrderIndex));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public int Flags
        {
            get { return this._Flags; }
            set
            {
                if (value != this._Flags)
                {
                    this._Flags = value;
                    this.NotifyOfPropertyChange(nameof(Flags));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public string WeaponSkin
        {
            get { return this._WeaponSkin; }
            set
            {
                if (value != this._WeaponSkin)
                {
                    this._WeaponSkin = value;
                    this.NotifyOfPropertyChange(nameof(WeaponSkin));
                }
            }
        }

        [ProtoMember(5, IsRequired = false)]
        public InventoryBalanceStateInitializationData DevelopmentSaveData
        {
            get { return this._DevelopmentSaveData; }
            set
            {
                if (value != this._DevelopmentSaveData)
                {
                    this._DevelopmentSaveData = value;
                    this.NotifyOfPropertyChange(nameof(DevelopmentSaveData));
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
