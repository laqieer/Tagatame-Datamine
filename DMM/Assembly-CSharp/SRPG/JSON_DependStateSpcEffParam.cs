// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DependStateSpcEffParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DEF")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DependStateSpcEffParam
  {
    [Token(Token = "0x40078B5")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40078B6")]
    [FieldOffset(Offset = "0xC")]
    public int is_and;
    [Token(Token = "0x40078B7")]
    [FieldOffset(Offset = "0x10")]
    public int[] buff_ids;
    [Token(Token = "0x40078B8")]
    [FieldOffset(Offset = "0x14")]
    public int[] buff_types;
    [Token(Token = "0x40078B9")]
    [FieldOffset(Offset = "0x18")]
    public int[] cond_ids;
    [Token(Token = "0x40078BA")]
    [FieldOffset(Offset = "0x1C")]
    public int inv_tkrate;
    [Token(Token = "0x40078BB")]
    [FieldOffset(Offset = "0x20")]
    public int is_inv_t_buff;
    [Token(Token = "0x40078BC")]
    [FieldOffset(Offset = "0x24")]
    public int is_inv_t_cond;
    [Token(Token = "0x40078BD")]
    [FieldOffset(Offset = "0x28")]
    public int is_inv_s_buff;
    [Token(Token = "0x40078BE")]
    [FieldOffset(Offset = "0x2C")]
    public int is_inv_s_cond;

    [Token(Token = "0x6007A6E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DependStateSpcEffParam()
    {
    }
  }
}
