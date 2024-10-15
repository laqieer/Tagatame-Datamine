// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.PointQuestPortRankingContentNodeExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200348B")]
  public class PointQuestPortRankingContentNodeExhibit : 
    BaseExhibit,
    IRenderModel<PointQuestPortRankingContentNodeModel>,
    IRenderModel
  {
    [Token(Token = "0x400F958")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (PointQuestPortRankingContentNodeExhibit.EKey), typeof (PointQuestPortRankingContentNodeExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9B5")]
    [Address(RVA = "0xAE6150", Offset = "0xAE4F50", VA = "0x10AE6150", Slot = "8")]
    public void Render(PointQuestPortRankingContentNodeModel model)
    {
    }

    [Token(Token = "0x600E9B6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestPortRankingContentNodeExhibit()
    {
    }

    [Token(Token = "0x200348C")]
    private enum EKey
    {
      [Token(Token = "0x400F95A")] None,
      [Token(Token = "0x400F95B")] RankingImage,
      [Token(Token = "0x400F95C")] RankingText,
      [Token(Token = "0x400F95D")] RankingOutRangeText,
      [Token(Token = "0x400F95E")] RankingNotAttended,
      [Token(Token = "0x400F95F")] PortEmblem,
      [Token(Token = "0x400F960")] PortNameText,
      [Token(Token = "0x400F961")] PortMasterNameText,
      [Token(Token = "0x400F962")] PortLevelText,
      [Token(Token = "0x400F963")] PortScoreText,
      [Token(Token = "0x400F964")] Mask,
    }
  }
}
