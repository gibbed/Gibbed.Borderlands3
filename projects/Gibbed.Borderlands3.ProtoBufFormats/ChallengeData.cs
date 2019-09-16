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
    public class ChallengeData : INotifyPropertyChanged
    {
        #region Fields
        private int _CompletedCount;
        private bool _IsActive;
        private bool _IsCurrentlyCompleted;
        private int _CompletedProgressLevel;
        private int _ProgressCounter;
        private List<ChallengeStatData> _StatInstanceState;
        private string _Challenge;

        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public int CompletedCount
        {
            get { return this._CompletedCount; }
            set
            {
                if (value != this._CompletedCount)
                {
                    this._CompletedCount = value;
                    this.NotifyOfPropertyChange(nameof(CompletedCount));
                }
            }
        }
        [ProtoMember(2, IsRequired = false)]
        public bool IsActive
        {
            get { return this._IsActive; }
            set
            {
                if (value != this._IsActive)
                {
                    this._IsActive = value;
                    this.NotifyOfPropertyChange(nameof(IsActive));
                }
            }
        }
        [ProtoMember(3, IsRequired = false)]
        public bool IsCurrentlyCompleted
        {
            get { return this._IsCurrentlyCompleted; }
            set
            {
                if (value != this._IsCurrentlyCompleted)
                {
                    this._IsCurrentlyCompleted = value;
                    this.NotifyOfPropertyChange(nameof(IsCurrentlyCompleted));
                }
            }
        }
        [ProtoMember(4, IsRequired = false)]
        public int CompletedProgressLevel
        {
            get { return this._CompletedProgressLevel; }
            set
            {
                if (value != this._CompletedProgressLevel)
                {
                    this._CompletedProgressLevel = value;
                    this.NotifyOfPropertyChange(nameof(CompletedProgressLevel));
                }
            }
        }
        [ProtoMember(5, IsRequired = false)]
        public int ProgressCounter
        {
            get { return this._ProgressCounter; }
            set
            {
                if (value != this._ProgressCounter)
                {
                    this._ProgressCounter = value;
                    this.NotifyOfPropertyChange(nameof(ProgressCounter));
                }
            }
        }
        [ProtoMember(6, IsRequired = true)]
        public List<ChallengeStatData> StatInstanceState
        {
            get { return this._StatInstanceState; }
            set
            {
                if (value != this._StatInstanceState)
                {
                    this._StatInstanceState = value;
                    this.NotifyOfPropertyChange(nameof(StatInstanceState));
                }
            }
        }
        [ProtoMember(7, IsRequired = false)]
        public string Challenge
        {
            get { return this._Challenge; }
            set
            {
                if (value != this._Challenge)
                {
                    this._Challenge = value;
                    this.NotifyOfPropertyChange(nameof(Challenge));
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
