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
    public class CharacterNicknameMapping : INotifyPropertyChanged
    {
        #region Fields
        private string _Key;
        private string _Value;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public string Key
        {
            get { return this._Key; }
            set
            {
                if (value != this._Key)
                {
                    this._Key = value;
                    this.NotifyOfPropertyChange(nameof(Key));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public string Value
        {
            get { return this._Value; }
            set
            {
                if (value != this._Value)
                {
                    this._Value = value;
                    this.NotifyOfPropertyChange(nameof(Value));
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
