// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinShopParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A40")]
  public class BuyCoinShopParam
  {
    [Token(Token = "0x40060AB")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int EXTENSION_DISP_DAY;
    [Token(Token = "0x40060AC")]
    [FieldOffset(Offset = "0x8")]
    private string mShopId;
    [Token(Token = "0x40060AD")]
    [FieldOffset(Offset = "0xC")]
    private BuyCoinManager.BuyCoinShopType mShopType;
    [Token(Token = "0x40060AE")]
    [FieldOffset(Offset = "0x10")]
    private string mDisplayName;
    [Token(Token = "0x40060AF")]
    [FieldOffset(Offset = "0x18")]
    private long mBeginAt;
    [Token(Token = "0x40060B0")]
    [FieldOffset(Offset = "0x20")]
    private long mEndAt;
    [Token(Token = "0x40060B1")]
    [FieldOffset(Offset = "0x28")]
    private bool mAlwaysOpen;
    [Token(Token = "0x40060B2")]
    [FieldOffset(Offset = "0x2C")]
    private string mUrl;

    [Token(Token = "0x17000BB8")]
    public string ShopId
    {
      [Token(Token = "0x6006BEE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BB9")]
    public BuyCoinManager.BuyCoinShopType ShopType
    {
      [Token(Token = "0x6006BEF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new BuyCoinManager.BuyCoinShopType();
      }
    }

    [Token(Token = "0x17000BBA")]
    public string DisplayName
    {
      [Token(Token = "0x6006BF0"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BBB")]
    public long BeginAt
    {
      [Token(Token = "0x6006BF1"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000BBC")]
    public long EndAt
    {
      [Token(Token = "0x6006BF2"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000BBD")]
    public bool AlwaysOpen
    {
      [Token(Token = "0x6006BF3"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000BBE")]
    public string Url
    {
      [Token(Token = "0x6006BF4"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006BF5")]
    [Address(RVA = "0x34F0C0", Offset = "0x34DEC0", VA = "0x1034F0C0")]
    public bool Deserialize(JSON_BuyCoinShopParam json) => new bool();

    [Token(Token = "0x6006BF6")]
    [Address(RVA = "0x34F3B0", Offset = "0x34E1B0", VA = "0x1034F3B0")]
    public bool IsInvalid() => new bool();

    [Token(Token = "0x6006BF7")]
    [Address(RVA = "0x34F240", Offset = "0x34E040", VA = "0x1034F240")]
    public bool IsEnableDisp() => new bool();

    [Token(Token = "0x6006BF8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinShopParam()
    {
    }

    [Token(Token = "0x6006BF9")]
    [Address(RVA = "0x34F440", Offset = "0x34E240", VA = "0x1034F440")]
    static BuyCoinShopParam()
    {
    }
  }
}
