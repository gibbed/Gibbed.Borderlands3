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
    public class CharacterActionAbilityAugmentConfigurationData : INotifyPropertyChanged
    {
        #region Fields
        private string _Ability;
        private string _Augment;
        private string _ModSlot;
        private string _Mod;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public string Ability
        {
            get { return this._Ability; }
            set
            {
                if (value != this._Ability)
                {
                    this._Ability = value;
                    this.NotifyOfPropertyChange(nameof(Ability));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public string Augment
        {
            get { return this._Augment; }
            set
            {
                if (value != this._Augment)
                {
                    this._Augment = value;
                    this.NotifyOfPropertyChange(nameof(Augment));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public string ModSlot
        {
            get { return this._ModSlot; }
            set
            {
                if (value != this._ModSlot)
                {
                    this._ModSlot = value;
                    this.NotifyOfPropertyChange(nameof(ModSlot));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public string Mod
        {
            get { return this._Mod; }
            set
            {
                if (value != this._Mod)
                {
                    this._Mod = value;
                    this.NotifyOfPropertyChange(nameof(Mod));
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
