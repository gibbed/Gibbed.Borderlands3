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
    public class ZoneMapFODSavedLevelData : INotifyPropertyChanged
    {
        #region Fields
        private string _LevelName;
        private uint _FODTextureSize;
        private uint _ChunkCount;
        private float _DiscoveryPercentage;
        private uint _DataState;
        private uint _DataRevision;
        private byte[] _FODData;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public string LevelName
        {
            get { return this._LevelName; }
            set
            {
                if (value != this._LevelName)
                {
                    this._LevelName = value;
                    this.NotifyOfPropertyChange(nameof(LevelName));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public uint FODTextureSize
        {
            get { return this._FODTextureSize; }
            set
            {
                if (value != this._FODTextureSize)
                {
                    this._FODTextureSize = value;
                    this.NotifyOfPropertyChange(nameof(FODTextureSize));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public uint ChunkCount
        {
            get { return this._ChunkCount; }
            set
            {
                if (value != this._ChunkCount)
                {
                    this._ChunkCount = value;
                    this.NotifyOfPropertyChange(nameof(ChunkCount));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public float DiscoveryPercentage
        {
            get { return this._DiscoveryPercentage; }
            set
            {
                if (value != this._DiscoveryPercentage)
                {
                    this._DiscoveryPercentage = value;
                    this.NotifyOfPropertyChange(nameof(DiscoveryPercentage));
                }
            }
        }

        [ProtoMember(5, IsRequired = false)]
        public uint DataState
        {
            get { return this._DataState; }
            set
            {
                if (value != this._DataState)
                {
                    this._DataState = value;
                    this.NotifyOfPropertyChange(nameof(DataState));
                }
            }
        }

        [ProtoMember(6, IsRequired = false)]
        public uint DataRevision
        {
            get { return this._DataRevision; }
            set
            {
                if (value != this._DataRevision)
                {
                    this._DataRevision = value;
                    this.NotifyOfPropertyChange(nameof(DataRevision));
                }
            }
        }

        [ProtoMember(7, IsRequired = false)]
        public byte[] FODData
        {
            get { return this._FODData; }
            set
            {
                if (value != this._FODData)
                {
                    this._FODData = value;
                    this.NotifyOfPropertyChange(nameof(FODData));
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
