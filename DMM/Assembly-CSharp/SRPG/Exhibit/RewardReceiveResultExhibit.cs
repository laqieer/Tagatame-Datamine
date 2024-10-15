// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RewardReceiveResultExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034A0")]
  public class RewardReceiveResultExhibit : 
    BaseExhibit,
    IRenderModel<RewardReceiveResultModel>,
    IRenderModel
  {
    [Token(Token = "0x400F9D8")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RewardReceiveResultExhibit.EKey), typeof (RewardReceiveResultExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F9D9")]
    [FieldOffset(Offset = "0x38")]
    public RaidRewardType Selftype;

    [Token(Token = "0x600E9E0")]
    [Address(RVA = "0xAEF4A0", Offset = "0xAEE2A0", VA = "0x10AEF4A0", Slot = "8")]
    public void Render(RewardReceiveResultModel model)
    {
    }

    [Token(Token = "0x600E9E1")]
    [Address(RVA = "0xAEF670", Offset = "0xAEE470", VA = "0x10AEF670")]
    private void SetIcon(RewardReceiveResultModel model)
    {
    }

    [Token(Token = "0x600E9E2")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RewardReceiveResultExhibit()
    {
    }

    [Token(Token = "0x20034A1")]
    private enum EKey
    {
      [Token(Token = "0x400F9DB")] None,
      [Token(Token = "0x400F9DC")] RewardTypeObj,
      [Token(Token = "0x400F9DD")] ReceiveNum,
      [Token(Token = "0x400F9DE")] NameText,
      [Token(Token = "0x400F9DF")] Icon,
      [Token(Token = "0x400F9E0")] IconFrame,
    }
  }
}
