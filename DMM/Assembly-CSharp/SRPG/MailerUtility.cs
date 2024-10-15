// Decompiled with JetBrains decompiler
// Type: SRPG.MailerUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FE0")]
  public class MailerUtility
  {
    [Token(Token = "0x6004211")]
    [Address(RVA = "0x1199FC0", Offset = "0x1198DC0", VA = "0x11199FC0")]
    public static (string, string, string) CreateContactMessage(int subjectType) => ();

    [Token(Token = "0x6004212")]
    [Address(RVA = "0x119A730", Offset = "0x1199530", VA = "0x1119A730")]
    public static void Launch(string mailto, string subject, string body)
    {
    }

    [Token(Token = "0x6004213")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MailerUtility()
    {
    }
  }
}
