# Vallerya

A 2D game built on the [Obsydian Engine](https://github.com/Vallerya-HQ/obsydian-engine).

## Setup

The engine is referenced as a sibling directory (no submodules):

```
Vallerya-HQ/
  obsydian-engine/  # Engine source
  vallerya/         # This repo
```

Clone both repos side by side:

```bash
git clone https://github.com/Vallerya-HQ/obsydian-engine.git
git clone https://github.com/Vallerya-HQ/vallerya.git
```

## Build

```bash
dotnet build
```

## Engine Pin

The `.engine-commit` file pins the tested engine SHA. After testing with a new engine version:

```bash
./pin-engine
```

## License

See [LICENSE](LICENSE).
