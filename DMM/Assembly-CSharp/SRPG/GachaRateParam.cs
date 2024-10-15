// Decompiled with JetBrains decompiler
// Type: SRPG.GachaRateParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001502")]
  public class GachaRateParam
  {
    [Token(Token = "0x4004CED")]
    [FieldOffset(Offset = "0x8")]
    private float m_rate;
    [Token(Token = "0x4004CEE")]
    [FieldOffset(Offset = "0xC")]
    private GachaDropData.Type m_type;
    [Token(Token = "0x4004CEF")]
    [FieldOffset(Offset = "0x10")]
    private float m_rate_coef;
    [Token(Token = "0x4004CF0")]
    [FieldOffset(Offset = "0x14")]
    private string m_name;
    [Token(Token = "0x4004CF1")]
    [FieldOffset(Offset = "0x18")]
    private int m_rarity;
    [Token(Token = "0x4004CF2")]
    [FieldOffset(Offset = "0x1C")]
    private EElement m_elem;
    [Token(Token = "0x4004CF3")]
    [FieldOffset(Offset = "0x20")]
    private int m_num;
    [Token(Token = "0x4004CF4")]
    [FieldOffset(Offset = "0x24")]
    private int m_hash;
    [Token(Token = "0x4004CF5")]
    [FieldOffset(Offset = "0x28")]
    public long sortPriority;

    [Token(Token = "0x17000947")]
    public float Rate
    {
      [Token(Token = "0x600574F"), Address(RVA = "0x3A3960", Offset = "0x3A2760", VA = "0x103A3960")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000948")]
    public GachaDropData.Type Type
    {
      [Token(Token = "0x6005750"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new GachaDropData.Type();
      }
    }

    [Token(Token = "0x17000949")]
    public float CalcRate
    {
      [Token(Token = "0x6005751"), Address(RVA = "0x12DB980", Offset = "0x12DA780", VA = "0x112DB980")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700094A")]
    public string name
    {
      [Token(Token = "0x6005752"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700094B")]
    public int rarity
    {
      [Token(Token = "0x6005753"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700094C")]
    public EElement elem
    {
      [Token(Token = "0x6005754"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x1700094D")]
    public int hash
    {
      [Token(Token = "0x6005755"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700094E")]
    public int num
    {
      [Token(Token = "0x6005756"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005757")]
    [Address(RVA = "0x12DB630", Offset = "0x12DA430", VA = "0x112DB630")]
    public bool Deserialize(JSON_GachaRateParam json) => new bool();

    [Token(Token = "0x6005758")]
    [Address(RVA = "0xB20590", Offset = "0xB1F390", VA = "0x10B20590")]
    public void SetCoef(float value)
    {
    }

    [Token(Token = "0x6005759")]
    [Address(RVA = "0x12DB930", Offset = "0x12DA730", VA = "0x112DB930")]
    public GachaRateParam()
    {
    }
  }
}
