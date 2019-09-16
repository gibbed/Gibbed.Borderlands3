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
    public class CharacterCustomColorData : INotifyPropertyChanged
    {
        #region Fields
        private string _ColorParameter;
        private Vec3 _AppliedColor;
        private Vec3 _AppliedSplitColor;
        private bool _UseDefaultColor;
        private bool _UseDefaultSplitColor;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public string ColorParameter
        {
            get { return this._ColorParameter; }
            set
            {
                if (value != this._ColorParameter)
                {
                    this._ColorParameter = value;
                    this.NotifyOfPropertyChange(nameof(ColorParameter));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public Vec3 AppliedColor
        {
            get { return this._AppliedColor; }
            set
            {
                if (value != this._AppliedColor)
                {
                    this._AppliedColor = value;
                    this.NotifyOfPropertyChange(nameof(AppliedColor));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public Vec3 AppliedSplitColor
        {
            get { return this._AppliedSplitColor; }
            set
            {
                if (value != this._AppliedSplitColor)
                {
                    this._AppliedSplitColor = value;
                    this.NotifyOfPropertyChange(nameof(AppliedSplitColor));
                }
            }
        }

        [ProtoMember(4, IsRequired = false)]
        public bool UseDefaultColor
        {
            get { return this._UseDefaultColor; }
            set
            {
                if (value != this._UseDefaultColor)
                {
                    this._UseDefaultColor = value;
                    this.NotifyOfPropertyChange(nameof(UseDefaultColor));
                }
            }
        }

        [ProtoMember(5, IsRequired = false)]
        public bool UseDefaultSplitColor
        {
            get { return this._UseDefaultSplitColor; }
            set
            {
                if (value != this._UseDefaultSplitColor)
                {
                    this._UseDefaultSplitColor = value;
                    this.NotifyOfPropertyChange(nameof(UseDefaultSplitColor));
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
