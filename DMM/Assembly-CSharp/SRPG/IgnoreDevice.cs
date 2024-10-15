// Decompiled with JetBrains decompiler
// Type: SRPG.IgnoreDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F2F")]
  public class IgnoreDevice
  {
    [Token(Token = "0x4002F58")]
    [FieldOffset(Offset = "0x8")]
    public string maker;
    [Token(Token = "0x4002F59")]
    [FieldOffset(Offset = "0xC")]
    public List<string> type_name_list;
    [Token(Token = "0x4002F5A")]
    [FieldOffset(Offset = "0x10")]
    public string os_version;

    [Token(Token = "0x6003F5C")]
    [Address(RVA = "0x1182840", Offset = "0x1181640", VA = "0x11182840")]
    public void SetDevices(string str_maker, string[] device_list, string str_osversion)
    {
    }

    [Token(Token = "0x6003F5D")]
    [Address(RVA = "0x1182980", Offset = "0x1181780", VA = "0x11182980")]
    public bool checkIgnoreDevice(string str_maker, string str_device, string str_osversion)
    {
      return new bool();
    }

    [Token(Token = "0x6003F5E")]
    [Address(RVA = "0x1182910", Offset = "0x1181710", VA = "0x11182910")]
    public IgnoreDevice()
    {
    }
  }
}
