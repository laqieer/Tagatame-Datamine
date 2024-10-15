// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePrideLotteryDetailParameterModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B1")]
  public class RunePrideLotteryDetailParameterModel : BaseParameterModel
  {
    [Token(Token = "0x400F49E")]
    [FieldOffset(Offset = "0x24")]
    private int min;
    [Token(Token = "0x400F49F")]
    [FieldOffset(Offset = "0x28")]
    private int max;
    [Token(Token = "0x400F4A0")]
    [FieldOffset(Offset = "0x2C")]
    private string statusStringMin;
    [Token(Token = "0x400F4A1")]
    [FieldOffset(Offset = "0x30")]
    private string statusStringMax;
    [Token(Token = "0x400F4A2")]
    [FieldOffset(Offset = "0x34")]
    public string MinValue;
    [Token(Token = "0x400F4A3")]
    [FieldOffset(Offset = "0x38")]
    public string MaxValue;

    [Token(Token = "0x600E6C7")]
    [Address(RVA = "0xAC64C0", Offset = "0xAC52C0", VA = "0x10AC64C0")]
    public void Initialize(RunePridePotentialStatusLotteryData data)
    {
    }

    [Token(Token = "0x600E6C8")]
    [Address(RVA = "0xAC66D0", Offset = "0xAC54D0", VA = "0x10AC66D0")]
    public RunePrideLotteryDetailParameterModel()
    {
    }
  }
}
