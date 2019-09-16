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
    public class MissionStatusData : INotifyPropertyChanged
    {
        #region Fields
        private MissionState _Status;
        private bool _HasBeenViewedInLog;
        private List<int> _ObjectivesProgress;
        private string _Mission;
        private string _ActiveObjectiveSet;
        private uint _DLCPackageID;
        private bool _KickoffPlayed;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public MissionState Status
        {
            get { return this._Status; }
            set
            {
                if (value != this._Status)
                {
                    this._Status = value;
                    this.NotifyOfPropertyChange(nameof(Status));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public bool HasBeenViewedInLog
        {
            get { return this._HasBeenViewedInLog; }
            set
            {
                if (value != this._HasBeenViewedInLog)
                {
                    this._HasBeenViewedInLog = value;
                    this.NotifyOfPropertyChange(nameof(HasBeenViewedInLog));
                }
            }
        }

        [ProtoMember(3, IsRequired = true, IsPacked = true)]
        public List<int> ObjectivesProgress
        {
            get { return this._ObjectivesProgress; }
            set
            {
                if (value != this._ObjectivesProgress)
                {
                    this._ObjectivesProgress = value;
                    this.NotifyOfPropertyChange(nameof(ObjectivesProgress));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public string Mission
        {
            get { return this._Mission; }
            set
            {
                if (value != this._Mission)
                {
                    this._Mission = value;
                    this.NotifyOfPropertyChange(nameof(Mission));
                }
            }
        }

        [ProtoMember(5, IsRequired = false)]
        public string ActiveObjectiveSet
        {
            get { return this._ActiveObjectiveSet; }
            set
            {
                if (value != this._ActiveObjectiveSet)
                {
                    this._ActiveObjectiveSet = value;
                    this.NotifyOfPropertyChange(nameof(ActiveObjectiveSet));
                }
            }
        }

        [ProtoMember(6, IsRequired = false)]
        public uint DLCPackageID
        {
            get { return this._DLCPackageID; }
            set
            {
                if (value != this._DLCPackageID)
                {
                    this._DLCPackageID = value;
                    this.NotifyOfPropertyChange(nameof(DLCPackageID));
                }
            }
        }

        [ProtoMember(7, IsRequired = false)]
        public bool KickoffPlayed
        {
            get { return this._KickoffPlayed; }
            set
            {
                if (value != this._KickoffPlayed)
                {
                    this._KickoffPlayed = value;
                    this.NotifyOfPropertyChange(nameof(KickoffPlayed));
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
