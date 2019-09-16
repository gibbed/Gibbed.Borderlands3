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
    public class CharacterActionAbilityAugmentData : INotifyPropertyChanged
    {
        #region Fields
        private string _ActionAbility;
        private string _Slot;
        private string _Augment;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public string ActionAbility
        {
            get { return this._ActionAbility; }
            set
            {
                if (value != this._ActionAbility)
                {
                    this._ActionAbility = value;
                    this.NotifyOfPropertyChange(nameof(ActionAbility));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public string Slot
        {
            get { return this._Slot; }
            set
            {
                if (value != this._Slot)
                {
                    this._Slot = value;
                    this.NotifyOfPropertyChange(nameof(Slot));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
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
