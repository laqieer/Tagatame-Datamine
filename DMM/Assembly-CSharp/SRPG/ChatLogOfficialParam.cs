// Decompiled with JetBrains decompiler
// Type: SRPG.ChatLogOfficialParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002183")]
  public class ChatLogOfficialParam : ChatLogParam
  {
    [Token(Token = "0x4009289")]
    [FieldOffset(Offset = "0x60")]
    public string title;
    [Token(Token = "0x400928A")]
    [FieldOffset(Offset = "0x64")]
    public string url;

    [Token(Token = "0x6008D0D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatLogOfficialParam()
    {
    }
  }
}
