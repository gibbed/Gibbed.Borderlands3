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
    public class CARMenuVehicleConfigurationData : INotifyPropertyChanged
    {
        #region Fields
        private string _LoadoutSaveName;
        private string _Body;
        private string _Wheel;
        private string _Armor;
        private string _CoreMod;
        private string _GunnerWeapon;
        private string _DriverWeapon;
        private string _Ornament;
        private string _MaterialDecal;
        private string _Material;
        private int _ColorIndex1;
        private int _ColorIndex2;
        private int _ColorIndex3;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public string LoadoutSaveName
        {
            get { return this._LoadoutSaveName; }
            set
            {
                if (value != this._LoadoutSaveName)
                {
                    this._LoadoutSaveName = value;
                    this.NotifyOfPropertyChange(nameof(LoadoutSaveName));
                }
            }
        }
        [ProtoMember(2, IsRequired = false)]
        public string Body
        {
            get { return this._Body; }
            set
            {
                if (value != this._Body)
                {
                    this._Body = value;
                    this.NotifyOfPropertyChange(nameof(Body));
                }
            }
        }
        [ProtoMember(3, IsRequired = false)]
        public string Wheel
        {
            get { return this._Wheel; }
            set
            {
                if (value != this._Wheel)
                {
                    this._Wheel = value;
                    this.NotifyOfPropertyChange(nameof(Wheel));
                }
            }
        }
        [ProtoMember(4, IsRequired = false)]
        public string Armor
        {
            get { return this._Armor; }
            set
            {
                if (value != this._Armor)
                {
                    this._Armor = value;
                    this.NotifyOfPropertyChange(nameof(Armor));
                }
            }
        }
        [ProtoMember(5, IsRequired = false)]
        public string CoreMod
        {
            get { return this._CoreMod; }
            set
            {
                if (value != this._CoreMod)
                {
                    this._CoreMod = value;
                    this.NotifyOfPropertyChange(nameof(CoreMod));
                }
            }
        }
        [ProtoMember(6, IsRequired = false)]
        public string GunnerWeapon
        {
            get { return this._GunnerWeapon; }
            set
            {
                if (value != this._GunnerWeapon)
                {
                    this._GunnerWeapon = value;
                    this.NotifyOfPropertyChange(nameof(GunnerWeapon));
                }
            }
        }
        [ProtoMember(7, IsRequired = false)]
        public string DriverWeapon
        {
            get { return this._DriverWeapon; }
            set
            {
                if (value != this._DriverWeapon)
                {
                    this._DriverWeapon = value;
                    this.NotifyOfPropertyChange(nameof(DriverWeapon));
                }
            }
        }
        [ProtoMember(8, IsRequired = false)]
        public string Ornament
        {
            get { return this._Ornament; }
            set
            {
                if (value != this._Ornament)
                {
                    this._Ornament = value;
                    this.NotifyOfPropertyChange(nameof(Ornament));
                }
            }
        }
        [ProtoMember(9, IsRequired = false)]
        public string MaterialDecal
        {
            get { return this._MaterialDecal; }
            set
            {
                if (value != this._MaterialDecal)
                {
                    this._MaterialDecal = value;
                    this.NotifyOfPropertyChange(nameof(MaterialDecal));
                }
            }
        }
        [ProtoMember(10, IsRequired = false)]
        public string Material
        {
            get { return this._Material; }
            set
            {
                if (value != this._Material)
                {
                    this._Material = value;
                    this.NotifyOfPropertyChange(nameof(Material));
                }
            }
        }
        [ProtoMember(11, IsRequired = false)]
        public int ColorIndex1
        {
            get { return this._ColorIndex1; }
            set
            {
                if (value != this._ColorIndex1)
                {
                    this._ColorIndex1 = value;
                    this.NotifyOfPropertyChange(nameof(ColorIndex1));
                }
            }
        }
        [ProtoMember(12, IsRequired = false)]
        public int ColorIndex2
        {
            get { return this._ColorIndex2; }
            set
            {
                if (value != this._ColorIndex2)
                {
                    this._ColorIndex2 = value;
                    this.NotifyOfPropertyChange(nameof(ColorIndex2));
                }
            }
        }
        [ProtoMember(13, IsRequired = false)]
        public int ColorIndex3
        {
            get { return this._ColorIndex3; }
            set
            {
                if (value != this._ColorIndex3)
                {
                    this._ColorIndex3 = value;
                    this.NotifyOfPropertyChange(nameof(ColorIndex3));
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
