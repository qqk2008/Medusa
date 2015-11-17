// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Geometry.proto
namespace Medusa.CoreProto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SizeU")]
  public partial class SizeU : global::ProtoBuf.IExtensible
  {
    public SizeU() {}
    
    private uint _Width;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Width", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Width
    {
      get { return _Width; }
      set { _Width = value; }
    }
    private uint _Height;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Height", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Height
    {
      get { return _Height; }
      set { _Height = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SizeF")]
  public partial class SizeF : global::ProtoBuf.IExtensible
  {
    public SizeF() {}
    
    private float _Width;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Width", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Width
    {
      get { return _Width; }
      set { _Width = value; }
    }
    private float _Height;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Height", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Height
    {
      get { return _Height; }
      set { _Height = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RangeU")]
  public partial class RangeU : global::ProtoBuf.IExtensible
  {
    public RangeU() {}
    
    private uint _MinValue;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"MinValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint MinValue
    {
      get { return _MinValue; }
      set { _MinValue = value; }
    }
    private uint _MaxValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"MaxValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint MaxValue
    {
      get { return _MaxValue; }
      set { _MaxValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RangeF")]
  public partial class RangeF : global::ProtoBuf.IExtensible
  {
    public RangeF() {}
    
    private float _MinValue;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"MinValue", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float MinValue
    {
      get { return _MinValue; }
      set { _MinValue = value; }
    }
    private float _MaxValue;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"MaxValue", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float MaxValue
    {
      get { return _MaxValue; }
      set { _MaxValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PointU")]
  public partial class PointU : global::ProtoBuf.IExtensible
  {
    public PointU() {}
    
    private uint _X;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"X", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint X
    {
      get { return _X; }
      set { _X = value; }
    }
    private uint _Y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Y
    {
      get { return _Y; }
      set { _Y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PointF")]
  public partial class PointF : global::ProtoBuf.IExtensible
  {
    public PointF() {}
    
    private float _X;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"X", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float X
    {
      get { return _X; }
      set { _X = value; }
    }
    private float _Y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Y
    {
      get { return _Y; }
      set { _Y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ScaleU")]
  public partial class ScaleU : global::ProtoBuf.IExtensible
  {
    public ScaleU() {}
    
    private uint _X;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"X", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint X
    {
      get { return _X; }
      set { _X = value; }
    }
    private uint _Y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Y
    {
      get { return _Y; }
      set { _Y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ScaleF")]
  public partial class ScaleF : global::ProtoBuf.IExtensible
  {
    public ScaleF() {}
    
    private float _X;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"X", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float X
    {
      get { return _X; }
      set { _X = value; }
    }
    private float _Y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Y", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float Y
    {
      get { return _Y; }
      set { _Y = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ColorF")]
  public partial class ColorF : global::ProtoBuf.IExtensible
  {
    public ColorF() {}
    
    private float _R;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"R", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float R
    {
      get { return _R; }
      set { _R = value; }
    }
    private float _G;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"G", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float G
    {
      get { return _G; }
      set { _G = value; }
    }
    private float _B;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"B", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float B
    {
      get { return _B; }
      set { _B = value; }
    }
    private float _A;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"A", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float A
    {
      get { return _A; }
      set { _A = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ColorU")]
  public partial class ColorU : global::ProtoBuf.IExtensible
  {
    public ColorU() {}
    
    private uint _R;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"R", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint R
    {
      get { return _R; }
      set { _R = value; }
    }
    private uint _G;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"G", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint G
    {
      get { return _G; }
      set { _G = value; }
    }
    private uint _B;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"B", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint B
    {
      get { return _B; }
      set { _B = value; }
    }
    private uint _A;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"A", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint A
    {
      get { return _A; }
      set { _A = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RectU")]
  public partial class RectU : global::ProtoBuf.IExtensible
  {
    public RectU() {}
    
    private Medusa.CoreProto.PointU _Origin;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Origin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Medusa.CoreProto.PointU Origin
    {
      get { return _Origin; }
      set { _Origin = value; }
    }
    private Medusa.CoreProto.SizeU _Size;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Medusa.CoreProto.SizeU Size
    {
      get { return _Size; }
      set { _Size = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RectF")]
  public partial class RectF : global::ProtoBuf.IExtensible
  {
    public RectF() {}
    
    private Medusa.CoreProto.PointF _Origin;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Origin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Medusa.CoreProto.PointF Origin
    {
      get { return _Origin; }
      set { _Origin = value; }
    }
    private Medusa.CoreProto.SizeF _Size;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Medusa.CoreProto.SizeF Size
    {
      get { return _Size; }
      set { _Size = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BorderU")]
  public partial class BorderU : global::ProtoBuf.IExtensible
  {
    public BorderU() {}
    
    private uint _Left;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Left", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Left
    {
      get { return _Left; }
      set { _Left = value; }
    }
    private uint _Right;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Right", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Right
    {
      get { return _Right; }
      set { _Right = value; }
    }
    private uint _Top;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Top", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Top
    {
      get { return _Top; }
      set { _Top = value; }
    }
    private uint _Bottom;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Bottom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Bottom
    {
      get { return _Bottom; }
      set { _Bottom = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}