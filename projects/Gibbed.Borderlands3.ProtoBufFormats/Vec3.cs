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
    public struct Vec3 : INotifyPropertyChanged
    {
        #region Fields
        private float _X;
        private float _Y;
        private float _Z;
        #endregion

        #region Properties
        [ProtoMember(1, IsRequired = false)]
        public float X
        {
            get { return this._X; }
            set
            {
                if (value != this._X)
                {
                    this._X = value;
                    this.NotifyOfPropertyChange(nameof(X));
                }
            }
        }

        [ProtoMember(2, IsRequired = false)]
        public float Y
        {
            get { return this._Y; }
            set
            {
                if (value != this._Y)
                {
                    this._Y = value;
                    this.NotifyOfPropertyChange(nameof(Y));
                }
            }
        }

        [ProtoMember(3, IsRequired = false)]
        public float Z
        {
            get { return this._Z; }
            set
            {
                if (value != this._Z)
                {
                    this._Z = value;
                    this.NotifyOfPropertyChange(nameof(Z));
                }
            }
        }
        #endregion

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }

            return (Vec3)obj == this;
        }

        public static bool operator ==(Vec3 a, Vec3 b)
        {
            return a._X == b._X &&
                   a._Y == b._Y &&
                   a._Z == b._Z;
        }

        public static bool operator !=(Vec3 a, Vec3 b)
        {
            return a._X != b._X ||
                   a._Y != b._Y ||
                   a._Z != b._Z;
        }

        public override int GetHashCode()
        {
            int hash = 37;
            hash = hash * 23 + this._X.GetHashCode();
            hash = hash * 23 + this._Y.GetHashCode();
            hash = hash * 23 + this._Z.GetHashCode();
            return hash;
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
