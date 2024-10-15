// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PortRankingExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003499")]
  public class PortRankingExhibit : BaseExhibit, IRenderModel<PortRankingModel>, IRenderModel
  {
    [Token(Token = "0x400F9B8")]
    private const int OUT_OF_RANK_VALUE = -1;
    [Token(Token = "0x400F9B9")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PortRankingExhibit.EKey), typeof (PortRankingExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F9BA")]
    [FieldOffset(Offset = "0x38")]
    public Image mPortEmblem;

    [Token(Token = "0x600E9D2")]
    [Address(RVA = "0xAECCC0", Offset = "0xAEBAC0", VA = "0x10AECCC0", Slot = "8")]
    public void Render(PortRankingModel _model)
    {
    }

    [Token(Token = "0x600E9D3")]
    [Address(RVA = "0xAED0E0", Offset = "0xAEBEE0", VA = "0x10AED0E0")]
    private void SetPortEmblem(string name)
    {
    }

    [Token(Token = "0x600E9D4")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public PortRankingExhibit()
    {
    }

    [Token(Token = "0x200349A")]
    private enum EKey
    {
      [Token(Token = "0x400F9BC")] None,
      [Token(Token = "0x400F9BD")] RankText,
      [Token(Token = "0x400F9BE")] RankImage,
      [Token(Token = "0x400F9BF")] Emblem,
      [Token(Token = "0x400F9C0")] Name,
      [Token(Token = "0x400F9C1")] Level,
      [Token(Token = "0x400F9C2")] MasterName,
      [Token(Token = "0x400F9C3")] CombatPower,
    }
  }
}
