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
    public class CrewQuartersRoomData : INotifyPropertyChanged
    {
        #region Fields
        private int _PreferredRoomAssignment;
        private List<CrewQuartersDecorationData> _Decorations;
        private string _Room;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public int PreferredRoomAssignment
        {
            get { return this._PreferredRoomAssignment; }
            set
            {
                if (value != this._PreferredRoomAssignment)
                {
                    this._PreferredRoomAssignment = value;
                    this.NotifyOfPropertyChange(nameof(PreferredRoomAssignment));
                }
            }
        }

        [ProtoMember(2, IsRequired = true)]
        public List<CrewQuartersDecorationData> Decorations
        {
            get { return this._Decorations; }
            set
            {
                if (value != this._Decorations)
                {
                    this._Decorations = value;
                    this.NotifyOfPropertyChange(nameof(Decorations));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public string Room
        {
            get { return this._Room; }
            set
            {
                if (value != this._Room)
                {
                    this._Room = value;
                    this.NotifyOfPropertyChange(nameof(Room));
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
