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
    public class UITrackingData : INotifyPropertyChanged
    {
        #region Fields
        private bool _HasSeenSkillMenuUnlock;
        private bool _HasSeenGuardianRankMenuUnlock;
        private bool _HasSeenEchoBootAmmoBar;
        private bool _HasSeenEchoBootShieldBar;
        private bool _HasSeenEchoBootGrenades;
        private int _HighestTHVMBreadcrumbSeen;
        private List<string> _InventorySlotUnlocksSeen;
        private int _SavedSpinOffset;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public bool HasSeenSkillMenuUnlock
        {
            get { return this._HasSeenSkillMenuUnlock; }
            set
            {
                if (value != this._HasSeenSkillMenuUnlock)
                {
                    this._HasSeenSkillMenuUnlock = value;
                    this.NotifyOfPropertyChange(nameof(HasSeenSkillMenuUnlock));
                }
            }
        }
        [ProtoMember(2, IsRequired = false)]
        public bool HasSeenGuardianRankMenuUnlock
        {
            get { return this._HasSeenGuardianRankMenuUnlock; }
            set
            {
                if (value != this._HasSeenGuardianRankMenuUnlock)
                {
                    this._HasSeenGuardianRankMenuUnlock = value;
                    this.NotifyOfPropertyChange(nameof(HasSeenGuardianRankMenuUnlock));
                }
            }
        }
        [ProtoMember(3, IsRequired = false)]
        public bool HasSeenEchoBootAmmoBar
        {
            get { return this._HasSeenEchoBootAmmoBar; }
            set
            {
                if (value != this._HasSeenEchoBootAmmoBar)
                {
                    this._HasSeenEchoBootAmmoBar = value;
                    this.NotifyOfPropertyChange(nameof(HasSeenEchoBootAmmoBar));
                }
            }
        }
        [ProtoMember(4, IsRequired = false)]
        public bool HasSeenEchoBootShieldBar
        {
            get { return this._HasSeenEchoBootShieldBar; }
            set
            {
                if (value != this._HasSeenEchoBootShieldBar)
                {
                    this._HasSeenEchoBootShieldBar = value;
                    this.NotifyOfPropertyChange(nameof(HasSeenEchoBootShieldBar));
                }
            }
        }
        [ProtoMember(5, IsRequired = false)]
        public bool HasSeenEchoBootGrenades
        {
            get { return this._HasSeenEchoBootGrenades; }
            set
            {
                if (value != this._HasSeenEchoBootGrenades)
                {
                    this._HasSeenEchoBootGrenades = value;
                    this.NotifyOfPropertyChange(nameof(HasSeenEchoBootGrenades));
                }
            }
        }
        [ProtoMember(6, IsRequired = false)]
        public int HighestTHVMBreadcrumbSeen
        {
            get { return this._HighestTHVMBreadcrumbSeen; }
            set
            {
                if (value != this._HighestTHVMBreadcrumbSeen)
                {
                    this._HighestTHVMBreadcrumbSeen = value;
                    this.NotifyOfPropertyChange(nameof(HighestTHVMBreadcrumbSeen));
                }
            }
        }
        [ProtoMember(7, IsRequired = true)]
        public List<string> InventorySlotUnlocksSeen
        {
            get { return this._InventorySlotUnlocksSeen; }
            set
            {
                if (value != this._InventorySlotUnlocksSeen)
                {
                    this._InventorySlotUnlocksSeen = value;
                    this.NotifyOfPropertyChange(nameof(InventorySlotUnlocksSeen));
                }
            }
        }
        [ProtoMember(8, IsRequired = false)]
        public int SavedSpinOffset
        {
            get { return this._SavedSpinOffset; }
            set
            {
                if (value != this._SavedSpinOffset)
                {
                    this._SavedSpinOffset = value;
                    this.NotifyOfPropertyChange(nameof(SavedSpinOffset));
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
