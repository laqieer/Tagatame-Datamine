// Decompiled with JetBrains decompiler
// Type: SRPG.CriticalSection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000ED9")]
  public static class CriticalSection
  {
    [Token(Token = "0x4002DAE")]
    [FieldOffset(Offset = "0x0")]
    private static int[] mCounts;
    [Token(Token = "0x4002DAF")]
    private const int NumMasks = 4;

    [Token(Token = "0x6003DAD")]
    [Address(RVA = "0x10F5030", Offset = "0x10F3E30", VA = "0x110F5030")]
    public static CriticalSections GetActive() => new CriticalSections();

    [Token(Token = "0x6003DAE")]
    [Address(RVA = "0x10F4FC0", Offset = "0x10F3DC0", VA = "0x110F4FC0")]
    public static void ForceReset()
    {
    }

    [Token(Token = "0x6003DAF")]
    [Address(RVA = "0x10F4EB0", Offset = "0x10F3CB0", VA = "0x110F4EB0")]
    public static void Enter(CriticalSections mask = CriticalSections.Default)
    {
    }

    [Token(Token = "0x6003DB0")]
    [Address(RVA = "0x10F50B0", Offset = "0x10F3EB0", VA = "0x110F50B0")]
    public static void Leave(CriticalSections mask = CriticalSections.Default)
    {
    }

    [Token(Token = "0x170004EE")]
    public static bool IsActive
    {
      [Token(Token = "0x6003DB1"), Address(RVA = "0x10F5270", Offset = "0x10F4070", VA = "0x110F5270")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003DB2")]
    [Address(RVA = "0x10F51C0", Offset = "0x10F3FC0", VA = "0x110F51C0")]
    public static IEnumerator Wait() => (IEnumerator) null;

    [Token(Token = "0x6003DB3")]
    [Address(RVA = "0x10F5210", Offset = "0x10F4010", VA = "0x110F5210")]
    static CriticalSection()
    {
    }
  }
}
