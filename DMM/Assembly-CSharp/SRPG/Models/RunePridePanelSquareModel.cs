// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RunePridePanelSquareModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033B4")]
  public class RunePridePanelSquareModel
  {
    [Token(Token = "0x400F4B8")]
    private const string DIRECTORY = "UI/RunePride/";
    [Token(Token = "0x400F4B9")]
    private const string NORMAL_ICON_SPRITE_SHEET_PATH = "RunePrideNormalParameterIcon";
    [Token(Token = "0x400F4BA")]
    private const string POTENTIAL_ICON_SPRITE_SHEET_PATH = "RunePridePotentialParameterIcon";
    [Token(Token = "0x400F4BB")]
    private const string OFF_SPRITE_ADD_STR = "_off";
    [Token(Token = "0x400F4BC")]
    private const string DEFAULT_SPRITE = "rune_pride_default";
    [Token(Token = "0x400F4BD")]
    [FieldOffset(Offset = "0x8")]
    private RunePridePanelSquareData data;
    [Token(Token = "0x400F4BE")]
    [FieldOffset(Offset = "0xC")]
    private bool isReleased;
    [Token(Token = "0x400F4BF")]
    [FieldOffset(Offset = "0xD")]
    private bool isAnotherRouteReleased;
    [Token(Token = "0x400F4C0")]
    [FieldOffset(Offset = "0xE")]
    private bool isStarOver;
    [Token(Token = "0x400F4C1")]
    [FieldOffset(Offset = "0x10")]
    private Sprite spriteOff;
    [Token(Token = "0x400F4C2")]
    [FieldOffset(Offset = "0x14")]
    private Sprite spriteOn;
    [Token(Token = "0x400F4C3")]
    [FieldOffset(Offset = "0x18")]
    private bool isSelect;
    [Token(Token = "0x400F4C4")]
    [FieldOffset(Offset = "0x19")]
    private bool isSelectable;
    [Token(Token = "0x400F4C5")]
    [FieldOffset(Offset = "0x1C")]
    private int releasedPrevIdIndex;
    [Token(Token = "0x400F4C6")]
    [FieldOffset(Offset = "0x20")]
    private int squareIndex;
    [Token(Token = "0x400F4C7")]
    [FieldOffset(Offset = "0x24")]
    private bool isLastSheet;

    [Token(Token = "0x1700206E")]
    public RunePridePanelSquareData Data
    {
      [Token(Token = "0x600E6DA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (RunePridePanelSquareData) null;
      }
    }

    [Token(Token = "0x1700206F")]
    public int SquareId
    {
      [Token(Token = "0x600E6DB"), Address(RVA = "0x8054A0", Offset = "0x8042A0", VA = "0x108054A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002070")]
    public int ForkId
    {
      [Token(Token = "0x600E6DC"), Address(RVA = "0x805480", Offset = "0x804280", VA = "0x10805480")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002071")]
    public int RouteId
    {
      [Token(Token = "0x600E6DD"), Address(RVA = "0xAC6C60", Offset = "0xAC5A60", VA = "0x10AC6C60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002072")]
    public int SecondForkId
    {
      [Token(Token = "0x600E6DE"), Address(RVA = "0x749500", Offset = "0x748300", VA = "0x10749500")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002073")]
    public int SecondRouteId
    {
      [Token(Token = "0x600E6DF"), Address(RVA = "0xAC6C80", Offset = "0xAC5A80", VA = "0x10AC6C80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002074")]
    public int PotentialNum
    {
      [Token(Token = "0x600E6E0"), Address(RVA = "0xAC6C20", Offset = "0xAC5A20", VA = "0x10AC6C20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002075")]
    public bool IsPotential
    {
      [Token(Token = "0x600E6E1"), Address(RVA = "0xAC6C00", Offset = "0xAC5A00", VA = "0x10AC6C00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002076")]
    public ParamTypes Type
    {
      [Token(Token = "0x600E6E2"), Address(RVA = "0xAC6CC0", Offset = "0xAC5AC0", VA = "0x10AC6CC0")] get
      {
        return new ParamTypes();
      }
    }

    [Token(Token = "0x17002077")]
    public string Tag
    {
      [Token(Token = "0x600E6E3"), Address(RVA = "0xAC6CA0", Offset = "0xAC5AA0", VA = "0x10AC6CA0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002078")]
    public int UpValue
    {
      [Token(Token = "0x600E6E4"), Address(RVA = "0xAC6CE0", Offset = "0xAC5AE0", VA = "0x10AC6CE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002079")]
    public Sprite SpriteOff
    {
      [Token(Token = "0x600E6E5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x1700207A")]
    public Sprite SpriteOn
    {
      [Token(Token = "0x600E6E6"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x1700207B")]
    public bool IsReleased
    {
      [Token(Token = "0x600E6E7"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700207C")]
    public bool IsAnotherRouteReleased
    {
      [Token(Token = "0x600E6E8"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700207D")]
    public bool IsStarOver
    {
      [Token(Token = "0x600E6E9"), Address(RVA = "0x3E7F60", Offset = "0x3E6D60", VA = "0x103E7F60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700207E")]
    public int[] PrevIds
    {
      [Token(Token = "0x600E6EA"), Address(RVA = "0xAC6C40", Offset = "0xAC5A40", VA = "0x10AC6C40")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x1700207F")]
    public bool IsSelect
    {
      [Token(Token = "0x600E6EB"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002080")]
    public bool IsGoal
    {
      [Token(Token = "0x600E6EC"), Address(RVA = "0xAC6BE0", Offset = "0xAC59E0", VA = "0x10AC6BE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002081")]
    public int SquareIndex
    {
      [Token(Token = "0x600E6ED"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002082")]
    public int ReleasedPrevIdIndex
    {
      [Token(Token = "0x600E6EE"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002083")]
    public bool IsSelectable
    {
      [Token(Token = "0x600E6EF"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002084")]
    public bool IsLastSheet
    {
      [Token(Token = "0x600E6F0"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E6F1")]
    [Address(RVA = "0xAC6890", Offset = "0xAC5690", VA = "0x10AC6890")]
    public void Initialize(RunePridePanelSquareData data, bool isReleased, bool isLastSheet = false)
    {
    }

    [Token(Token = "0x600E6F2")]
    [Address(RVA = "0xAC6960", Offset = "0xAC5760", VA = "0x10AC6960")]
    private void SetIconSprites()
    {
    }

    [Token(Token = "0x600E6F3")]
    [Address(RVA = "0xAC6B70", Offset = "0xAC5970", VA = "0x10AC6B70")]
    private void SetIndex()
    {
    }

    [Token(Token = "0x600E6F4")]
    [Address(RVA = "0x3DA470", Offset = "0x3D9270", VA = "0x103DA470")]
    public void SetAnotherRouteReleased(bool isAnotherRouteReleased)
    {
    }

    [Token(Token = "0x600E6F5")]
    [Address(RVA = "0xAC6BB0", Offset = "0xAC59B0", VA = "0x10AC6BB0")]
    public void SetStarOver(bool isStarOver)
    {
    }

    [Token(Token = "0x600E6F6")]
    [Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")]
    public void SetReleasedPrevIdIndex(int releasedPrevIdIndex)
    {
    }

    [Token(Token = "0x600E6F7")]
    [Address(RVA = "0xAC6940", Offset = "0xAC5740", VA = "0x10AC6940")]
    public void OnSelect(bool isSelect)
    {
    }

    [Token(Token = "0x600E6F8")]
    [Address(RVA = "0xAC6900", Offset = "0xAC5700", VA = "0x10AC6900")]
    public void OnRelease()
    {
    }

    [Token(Token = "0x600E6F9")]
    [Address(RVA = "0x4082C0", Offset = "0x4070C0", VA = "0x104082C0")]
    public void SetSelectable(bool isSelectable)
    {
    }

    [Token(Token = "0x600E6FA")]
    [Address(RVA = "0xAC6BC0", Offset = "0xAC59C0", VA = "0x10AC6BC0")]
    public RunePridePanelSquareModel()
    {
    }
  }
}
