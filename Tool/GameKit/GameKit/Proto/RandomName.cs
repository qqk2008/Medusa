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

// Generated from: RandomName.proto
namespace Medusa.CoreProto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RandomNameConfigItem")]
  public partial class RandomNameConfigItem : global::ProtoBuf.IExtensible
  {
    public RandomNameConfigItem() {}
    
    private uint _Position;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Position
    {
      get { return _Position; }
      set { _Position = value; }
    }
    private string _Value;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Value
    {
      get { return _Value; }
      set { _Value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RandomNameConfig")]
  public partial class RandomNameConfig : global::ProtoBuf.IExtensible
  {
    public RandomNameConfig() {}
    
    private readonly global::System.Collections.Generic.List<Medusa.CoreProto.RandomNameConfigItem> _Items = new global::System.Collections.Generic.List<Medusa.CoreProto.RandomNameConfigItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Medusa.CoreProto.RandomNameConfigItem> Items
    {
      get { return _Items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}