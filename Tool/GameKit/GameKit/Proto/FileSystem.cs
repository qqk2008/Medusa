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

// Generated from: FileSystem.proto
// Note: requires additional types generated from: Geometry.proto
namespace Medusa.CoreProto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FileId")]
  public partial class FileId : global::ProtoBuf.IExtensible
  {
    public FileId() {}
    
    private string _Name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }

    private uint _Order = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint Order
    {
      get { return _Order; }
      set { _Order = value; }
    }

    private int _Tag = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Tag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Tag
    {
      get { return _Tag; }
      set { _Tag = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FileSystemOrderItem")]
  public partial class FileSystemOrderItem : global::ProtoBuf.IExtensible
  {
    public FileSystemOrderItem() {}
    
    private uint _Order;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Order
    {
      get { return _Order; }
      set { _Order = value; }
    }

    private uint _FileId = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"FileId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint FileId
    {
      get { return _FileId; }
      set { _FileId = value; }
    }

    private Medusa.CoreProto.RectU _TextureRect = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TextureRect", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Medusa.CoreProto.RectU TextureRect
    {
      get { return _TextureRect; }
      set { _TextureRect = value; }
    }

    private Medusa.CoreProto.PointU _Offset = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Offset", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Medusa.CoreProto.PointU Offset
    {
      get { return _Offset; }
      set { _Offset = value; }
    }

    private Medusa.CoreProto.SizeU _OriginalSize = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"OriginalSize", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Medusa.CoreProto.SizeU OriginalSize
    {
      get { return _OriginalSize; }
      set { _OriginalSize = value; }
    }

    private byte[] _Data = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] Data
    {
      get { return _Data; }
      set { _Data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FileSystemNameItem")]
  public partial class FileSystemNameItem : global::ProtoBuf.IExtensible
  {
    public FileSystemNameItem() {}
    
    private string _Name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private readonly global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemOrderItem> _OrderItems = new global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemOrderItem>();
    [global::ProtoBuf.ProtoMember(2, Name=@"OrderItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemOrderItem> OrderItems
    {
      get { return _OrderItems; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FileSystemTagItem")]
  public partial class FileSystemTagItem : global::ProtoBuf.IExtensible
  {
    public FileSystemTagItem() {}
    
    private int _Tag;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Tag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Tag
    {
      get { return _Tag; }
      set { _Tag = value; }
    }
    private readonly global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemNameItem> _NameItems = new global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemNameItem>();
    [global::ProtoBuf.ProtoMember(2, Name=@"NameItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemNameItem> NameItems
    {
      get { return _NameItems; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FileSystem")]
  public partial class FileSystem : global::ProtoBuf.IExtensible
  {
    public FileSystem() {}
    
    private readonly global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemTagItem> _TagItems = new global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemTagItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"TagItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Medusa.CoreProto.FileSystemTagItem> TagItems
    {
      get { return _TagItems; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}