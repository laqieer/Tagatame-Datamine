// Decompiled with JetBrains decompiler
// Type: SRPG.RuneStatusList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029F4")]
  [AddComponentMenu("UI/Rune/RuneStatusList")]
  public class RuneStatusList : StatusList
  {
    [Token(Token = "0x400CBD4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ImageSpriteSheet m_SetEffectIcon;
    [Token(Token = "0x400CBD5")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text m_SetEffectName;

    [Token(Token = "0x600BF3E")]
    [Address(RVA = "0x867E30", Offset = "0x866C30", VA = "0x10867E30")]
    public void SetRuneSetEffect(int iconIndex, string name)
    {
    }

    [Token(Token = "0x600BF3F")]
    [Address(RVA = "0x867E90", Offset = "0x866C90", VA = "0x10867E90")]
    public RuneStatusList()
    {
    }
  }
}
