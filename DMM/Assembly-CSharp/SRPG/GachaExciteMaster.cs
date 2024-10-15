// Decompiled with JetBrains decompiler
// Type: SRPG.GachaExciteMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F22")]
  public class GachaExciteMaster
  {
    [Token(Token = "0x4002F28")]
    [FieldOffset(Offset = "0x0")]
    private static int[] CRYSTAL_EXCITE_LOW;
    [Token(Token = "0x4002F29")]
    [FieldOffset(Offset = "0x4")]
    private static int[] CRYSTAL_EXCITE_MIDDLE;
    [Token(Token = "0x4002F2A")]
    [FieldOffset(Offset = "0x8")]
    private static int[] CRYSTAL_EXCITE_HIGH;

    [Token(Token = "0x6003F29")]
    [Address(RVA = "0x1176180", Offset = "0x1174F80", VA = "0x11176180")]
    public static int[] Select(Json_GachaExcite[] json, int rare) => (int[]) null;

    [Token(Token = "0x6003F2A")]
    [Address(RVA = "0x1175EA0", Offset = "0x1174CA0", VA = "0x11175EA0")]
    public static int[] SelectStone(GachaDropData.Type type, Json_GachaExcite[] json, int rare)
    {
      return (int[]) null;
    }

    [Token(Token = "0x6003F2B")]
    [Address(RVA = "0x1175E10", Offset = "0x1174C10", VA = "0x11175E10")]
    public static int[] SelectStoneCrystal(int rank) => (int[]) null;

    [Token(Token = "0x6003F2C")]
    [Address(RVA = "0x1175F90", Offset = "0x1174D90", VA = "0x11175F90")]
    public static int[] SelectStone(Json_GachaExcite[] json, int rare) => (int[]) null;

    [Token(Token = "0x6003F2D")]
    [Address(RVA = "0x1175D60", Offset = "0x1174B60", VA = "0x11175D60")]
    private static int ColorString2Int(string cstr) => new int();

    [Token(Token = "0x6003F2E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GachaExciteMaster()
    {
    }

    [Token(Token = "0x6003F2F")]
    [Address(RVA = "0x11763C0", Offset = "0x11751C0", VA = "0x111763C0")]
    static GachaExciteMaster()
    {
    }
  }
}
