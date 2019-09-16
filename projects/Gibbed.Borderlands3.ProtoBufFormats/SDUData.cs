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
    public class SDUData : INotifyPropertyChanged
    {
        #region Fields
        private int _Level;
        private string _SDU;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public int Level
        {
            get { return this._Level; }
            set
            {
                if (value != this._Level)
                {
                    this._Level = value;
                    this.NotifyOfPropertyChange(nameof(Level));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public string SDU
        {
            get { return this._SDU; }
            set
            {
                if (value != this._SDU)
                {
                    this._SDU = value;
                    this.NotifyOfPropertyChange(nameof(SDU));
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
