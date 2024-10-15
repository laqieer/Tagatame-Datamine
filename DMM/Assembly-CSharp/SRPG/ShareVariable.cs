// Decompiled with JetBrains decompiler
// Type: SRPG.ShareVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D16")]
  public class ShareVariable : Singleton<ShareVariable>
  {
    [Token(Token = "0x400721D")]
    [FieldOffset(Offset = "0x8")]
    public ShareString str;

    [Token(Token = "0x6007768")]
    [Address(RVA = "0x39F4D0", Offset = "0x39E2D0", VA = "0x1039F4D0")]
    public ShareVariable()
    {
    }
  }
}
