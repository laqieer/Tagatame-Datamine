// Decompiled with JetBrains decompiler
// Type: SRPG.ElementParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DFD")]
  [MessagePackObject(true)]
  public class ElementParam
  {
    [Token(Token = "0x4007914")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_ELEMENT;
    [Token(Token = "0x4007915")]
    [FieldOffset(Offset = "0x8")]
    public short[] values;
    [Token(Token = "0x4007916")]
    [FieldOffset(Offset = "0x4")]
    public static readonly ParamTypes[] ConvertAssistParamTypes;
    [Token(Token = "0x4007917")]
    [FieldOffset(Offset = "0x8")]
    public static readonly ParamTypes[] ConvertResistParamTypes;

    [Token(Token = "0x6007AAE")]
    [Address(RVA = "0x3DB080", Offset = "0x3D9E80", VA = "0x103DB080")]
    public string ToSuspendString() => (string) null;

    [Token(Token = "0x6007AAF")]
    [Address(RVA = "0x3DAB80", Offset = "0x3D9980", VA = "0x103DAB80")]
    public bool FromSuspendString(string str) => new bool();

    [Token(Token = "0x170010BC")]
    [IgnoreMember]
    public short this[EElement type]
    {
      [Token(Token = "0x6007AB0"), Address(RVA = "0x3DB290", Offset = "0x3DA090", VA = "0x103DB290")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AB1"), Address(RVA = "0x3DB3E0", Offset = "0x3DA1E0", VA = "0x103DB3E0")] set
      {
      }
    }

    [Token(Token = "0x170010BD")]
    public short fire
    {
      [Token(Token = "0x6007AB2"), Address(RVA = "0x3DB2F0", Offset = "0x3DA0F0", VA = "0x103DB2F0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AB3"), Address(RVA = "0x3DB440", Offset = "0x3DA240", VA = "0x103DB440")] set
      {
      }
    }

    [Token(Token = "0x170010BE")]
    public short water
    {
      [Token(Token = "0x6007AB4"), Address(RVA = "0x3DB380", Offset = "0x3DA180", VA = "0x103DB380")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AB5"), Address(RVA = "0x3DB4D0", Offset = "0x3DA2D0", VA = "0x103DB4D0")] set
      {
      }
    }

    [Token(Token = "0x170010BF")]
    public short wind
    {
      [Token(Token = "0x6007AB6"), Address(RVA = "0x3DB3B0", Offset = "0x3DA1B0", VA = "0x103DB3B0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AB7"), Address(RVA = "0x3DB500", Offset = "0x3DA300", VA = "0x103DB500")] set
      {
      }
    }

    [Token(Token = "0x170010C0")]
    public short thunder
    {
      [Token(Token = "0x6007AB8"), Address(RVA = "0x3DB350", Offset = "0x3DA150", VA = "0x103DB350")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AB9"), Address(RVA = "0x3DB4A0", Offset = "0x3DA2A0", VA = "0x103DB4A0")] set
      {
      }
    }

    [Token(Token = "0x170010C1")]
    public short shine
    {
      [Token(Token = "0x6007ABA"), Address(RVA = "0x3DB320", Offset = "0x3DA120", VA = "0x103DB320")] get
      {
        return new short();
      }
      [Token(Token = "0x6007ABB"), Address(RVA = "0x3DB470", Offset = "0x3DA270", VA = "0x103DB470")] set
      {
      }
    }

    [Token(Token = "0x170010C2")]
    public short dark
    {
      [Token(Token = "0x6007ABC"), Address(RVA = "0x3DB2C0", Offset = "0x3DA0C0", VA = "0x103DB2C0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007ABD"), Address(RVA = "0x3DB410", Offset = "0x3DA210", VA = "0x103DB410")] set
      {
      }
    }

    [Token(Token = "0x6007ABE")]
    [Address(RVA = "0x3B84B0", Offset = "0x3B72B0", VA = "0x103B84B0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007ABF")]
    [Address(RVA = "0x3B84E0", Offset = "0x3B72E0", VA = "0x103B84E0")]
    public void CopyTo(ElementParam dsc)
    {
    }

    [Token(Token = "0x6007AC0")]
    [Address(RVA = "0x3DA9A0", Offset = "0x3D97A0", VA = "0x103DA9A0")]
    public void Add(ElementParam src)
    {
    }

    [Token(Token = "0x6007AC1")]
    [Address(RVA = "0x3DADA0", Offset = "0x3D9BA0", VA = "0x103DADA0")]
    public void Sub(ElementParam src)
    {
    }

    [Token(Token = "0x6007AC2")]
    [Address(RVA = "0x3DA750", Offset = "0x3D9550", VA = "0x103DA750")]
    public void AddRate(ElementParam src)
    {
    }

    [Token(Token = "0x6007AC3")]
    [Address(RVA = "0x3DA520", Offset = "0x3D9320", VA = "0x103DA520")]
    public void AddRateRoundUp(ElementParam src)
    {
    }

    [Token(Token = "0x6007AC4")]
    [Address(RVA = "0x3DAC90", Offset = "0x3D9A90", VA = "0x103DAC90")]
    public void SubRateRoundDown(long percent)
    {
    }

    [Token(Token = "0x6007AC5")]
    [Address(RVA = "0x3B86D0", Offset = "0x3B74D0", VA = "0x103B86D0")]
    public void ReplceHighest(ElementParam comp)
    {
    }

    [Token(Token = "0x6007AC6")]
    [Address(RVA = "0x3B8750", Offset = "0x3B7550", VA = "0x103B8750")]
    public void ReplceLowest(ElementParam comp)
    {
    }

    [Token(Token = "0x6007AC7")]
    [Address(RVA = "0x3B8310", Offset = "0x3B7110", VA = "0x103B8310")]
    public void ChoiceHighest(ElementParam scale, ElementParam base_status)
    {
    }

    [Token(Token = "0x6007AC8")]
    [Address(RVA = "0x3B83E0", Offset = "0x3B71E0", VA = "0x103B83E0")]
    public void ChoiceLowest(ElementParam scale, ElementParam base_status)
    {
    }

    [Token(Token = "0x6007AC9")]
    [Address(RVA = "0x3B7C10", Offset = "0x3B6A10", VA = "0x103B7C10")]
    public void AddConvRate(ElementParam scale, ElementParam base_status)
    {
    }

    [Token(Token = "0x6007ACA")]
    [Address(RVA = "0x3B87D0", Offset = "0x3B75D0", VA = "0x103B87D0")]
    public void SubConvRate(ElementParam scale, ElementParam base_status)
    {
    }

    [Token(Token = "0x6007ACB")]
    [Address(RVA = "0x3B8660", Offset = "0x3B7460", VA = "0x103B8660")]
    public void Mul(int mul_val)
    {
    }

    [Token(Token = "0x6007ACC")]
    [Address(RVA = "0x3B8550", Offset = "0x3B7350", VA = "0x103B8550")]
    public void Div(int div_val)
    {
    }

    [Token(Token = "0x6007ACD")]
    [Address(RVA = "0x3DAF80", Offset = "0x3D9D80", VA = "0x103DAF80")]
    public void Swap(ElementParam src, bool is_rev)
    {
    }

    [Token(Token = "0x6007ACE")]
    [Address(RVA = "0x3DABD0", Offset = "0x3D99D0", VA = "0x103DABD0")]
    public ParamTypes GetAssistParamTypes(int index) => new ParamTypes();

    [Token(Token = "0x6007ACF")]
    [Address(RVA = "0x3DAC30", Offset = "0x3D9A30", VA = "0x103DAC30")]
    public ParamTypes GetResistParamTypes(int index) => new ParamTypes();

    [Token(Token = "0x6007AD0")]
    [Address(RVA = "0x3DB210", Offset = "0x3DA010", VA = "0x103DB210")]
    public ElementParam()
    {
    }

    [Token(Token = "0x6007AD1")]
    [Address(RVA = "0x3DB0D0", Offset = "0x3D9ED0", VA = "0x103DB0D0")]
    static ElementParam()
    {
    }
  }
}
