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
    public class CharacterAbilityData : INotifyPropertyChanged
    {
        #region Fields
        private int _AbilityPoints;
        private List<CharacterAbilityTreeItemData> _TreeItems;
        private List<CharacterAbilitySlotData> _AbilitySlots;
        private List<CharacterActionAbilityAugmentData> _AugmentSlots;
        private List<CharacterActionAbilityAugmentConfigurationData> _AugmentConfigurations;
        private int _TreeGrade;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public int AbilityPoints
        {
            get { return this._AbilityPoints; }
            set
            {
                if (value != this._AbilityPoints)
                {
                    this._AbilityPoints = value;
                    this.NotifyOfPropertyChange(nameof(AbilityPoints));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public List<CharacterAbilityTreeItemData> TreeItems
        {
            get { return this._TreeItems; }
            set
            {
                if (value != this._TreeItems)
                {
                    this._TreeItems = value;
                    this.NotifyOfPropertyChange(nameof(TreeItems));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public List<CharacterAbilitySlotData> AbilitySlots
        {
            get { return this._AbilitySlots; }
            set
            {
                if (value != this._AbilitySlots)
                {
                    this._AbilitySlots = value;
                    this.NotifyOfPropertyChange(nameof(AbilitySlots));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public List<CharacterActionAbilityAugmentData> AugmentSlots
        {
            get { return this._AugmentSlots; }
            set
            {
                if (value != this._AugmentSlots)
                {
                    this._AugmentSlots = value;
                    this.NotifyOfPropertyChange(nameof(AugmentSlots));
                }
            }
        }

        [ProtoMember(5, IsRequired = false)]
        public List<CharacterActionAbilityAugmentConfigurationData> AugmentConfigurations
        {
            get { return this._AugmentConfigurations; }
            set
            {
                if (value != this._AugmentConfigurations)
                {
                    this._AugmentConfigurations = value;
                    this.NotifyOfPropertyChange(nameof(AugmentConfigurations));
                }
            }
        }

        [ProtoMember(6, IsRequired = false)]
        public int TreeGrade
        {
            get { return this._TreeGrade; }
            set
            {
                if (value != this._TreeGrade)
                {
                    this._TreeGrade = value;
                    this.NotifyOfPropertyChange(nameof(TreeGrade));
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
