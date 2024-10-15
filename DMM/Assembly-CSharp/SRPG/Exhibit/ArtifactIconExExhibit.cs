// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ArtifactIconExExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033EF")]
  public class ArtifactIconExExhibit : BaseExhibit, IRenderModel<ArtifactIconExModel>, IRenderModel
  {
    [Token(Token = "0x400F61F")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ArtifactIconExExhibit.EKey), typeof (ArtifactIconExExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E8C5")]
    [Address(RVA = "0xAD6140", Offset = "0xAD4F40", VA = "0x10AD6140", Slot = "8")]
    public void Render(ArtifactIconExModel model)
    {
    }

    [Token(Token = "0x600E8C6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactIconExExhibit()
    {
    }

    [Token(Token = "0x20033F0")]
    private enum EKey
    {
      [Token(Token = "0x400F621")] None,
      [Token(Token = "0x400F622")] Icon,
      [Token(Token = "0x400F623")] Rarity,
      [Token(Token = "0x400F624")] RarityMax,
      [Token(Token = "0x400F625")] RarityText,
      [Token(Token = "0x400F626")] RarityMaxText,
      [Token(Token = "0x400F627")] Frame,
      [Token(Token = "0x400F628")] Lv,
      [Token(Token = "0x400F629")] LvCap,
      [Token(Token = "0x400F62A")] PreLvCap,
      [Token(Token = "0x400F62B")] LvGauge,
      [Token(Token = "0x400F62C")] ExpGauge,
      [Token(Token = "0x400F62D")] PieceGauge,
      [Token(Token = "0x400F62E")] Category,
      [Token(Token = "0x400F62F")] Owner,
      [Token(Token = "0x400F630")] OwnerIcon,
      [Token(Token = "0x400F631")] DecCost,
      [Token(Token = "0x400F632")] DecKakeraNum,
      [Token(Token = "0x400F633")] TransmuteCost,
      [Token(Token = "0x400F634")] NotRarityUp,
      [Token(Token = "0x400F635")] CanRarityUp,
      [Token(Token = "0x400F636")] IndexBadge,
      [Token(Token = "0x400F637")] RarityUp,
      [Token(Token = "0x400F638")] CanCreate,
      [Token(Token = "0x400F639")] RarityUpBack,
      [Token(Token = "0x400F63A")] CanCreateBack,
      [Token(Token = "0x400F63B")] CanCreateGauge,
      [Token(Token = "0x400F63C")] DefaultGauge,
      [Token(Token = "0x400F63D")] DefaultBack,
      [Token(Token = "0x400F63E")] RarityUpCost,
      [Token(Token = "0x400F63F")] PieceNum,
      [Token(Token = "0x400F640")] NotCreateGrayIcon,
      [Token(Token = "0x400F641")] NotCreateGrayRawIcon,
      [Token(Token = "0x400F642")] Favorite,
      [Token(Token = "0x400F643")] LockMask,
      [Token(Token = "0x400F644")] EquipLockMask,
    }
  }
}
