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
    public class PlanetCycleInfo : INotifyPropertyChanged
    {
        #region Fields
        private string _PlanetName;
        private float _CycleLength;
        private float _LastCachedTime;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public string PlanetName
        {
            get { return this._PlanetName; }
            set
            {
                if (value != this._PlanetName)
                {
                    this._PlanetName = value;
                    this.NotifyOfPropertyChange(nameof(PlanetName));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public float CycleLength
        {
            get { return this._CycleLength; }
            set
            {
                if (value != this._CycleLength)
                {
                    this._CycleLength = value;
                    this.NotifyOfPropertyChange(nameof(CycleLength));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public float LastCachedTime
        {
            get { return this._LastCachedTime; }
            set
            {
                if (value != this._LastCachedTime)
                {
                    this._LastCachedTime = value;
                    this.NotifyOfPropertyChange(nameof(LastCachedTime));
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
