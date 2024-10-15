// Decompiled with JetBrains decompiler
// Type: SRPG.AutoInvalidSkillEditWindowTooltipVersion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200264F")]
  public class AutoInvalidSkillEditWindowTooltipVersion : MonoBehaviour
  {
    [Token(Token = "0x400B315")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string PATH_INVALID_SKILL_WINDOW;
    [Token(Token = "0x400B316")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ParentGameObject;

    [Token(Token = "0x600AB0F")]
    [Address(RVA = "0x6DA8B0", Offset = "0x6D96B0", VA = "0x106DA8B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AB10")]
    [Address(RVA = "0x6DA910", Offset = "0x6D9710", VA = "0x106DA910")]
    public bool Create() => new bool();

    [Token(Token = "0x600AB11")]
    [Address(RVA = "0x6DACD0", Offset = "0x6D9AD0", VA = "0x106DACD0")]
    public AutoInvalidSkillEditWindowTooltipVersion()
    {
    }
  }
}
