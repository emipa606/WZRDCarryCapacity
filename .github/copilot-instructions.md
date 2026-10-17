# GitHub Copilot Instructions for [WZRD] Carry Capacity (Continued)

## Mod Overview and Purpose

The "[WZRD] Carry Capacity (Continued)" mod is designed to enhance and customize the carrying capacity of pawns (colonists) and Transport Pods in RimWorld. By allowing for adjustable carry capacities, this mod empowers players to tailor their gameplay experience, making transportation and logistics more efficient, especially in scenarios involving caravans and resource management. The mod doubles the default carry capacity of pawns and pods upon installation, and these values can be further adjusted through the Mod Settings UI.

## Key Features and Systems

- **Pawn Carry Capacity Adjustment**: Customize how much individual pawns can carry, improving the management of logistics and resource distribution within your colony.
- **Transport Pod Capacity Enhancement**: Modify the capacity of Transport Pods to satisfy your colony’s transportation demands.
- **Caravan Planning**: Since caravan capacity is linked to pawn carrying ability, planning large expeditions becomes more manageable.
- **Mod Settings UI Integration**: Easily configurable settings for adjusting the carry capacity multipliers for both pawns and Transport Pods according to your preferences.
- **Save Compatibility**: The mod is fully compatible with existing save files, allowing installation and removal without disrupting gameplay.

## Coding Patterns and Conventions

- **Consistent Naming**: Follow existing conventions like PascalCase for class names (`WzrdCarryMod`, `WzrdCarrySettings`) and camelCase for method names (`DoSettingsWindowContents`, `ExposeData`).
- **Modular Structure**: Ensure mod features are encapsulated in specific classes like `WzrdCarryMod` and `WzrdCarrySettings` for easier maintenance and readability.
- **Minimal State Management**: Focus on using RimWorld's existing systems for data exposure, such as the `ExposeData` method, to maintain mod settings through game saves.

## XML Integration

The current version of the mod does not include XML files. However, if future updates require XML for defining new game objects or altering existing game data, consider using XML defs to ensure compatibility with RimWorld's modding framework. Use structure and indentation similar to base game XML files for consistency.

## Harmony Patching

- Use **Harmony** for patching game methods that relate to carry capacity. Harmony allows for non-destructive patches, ensuring that your changes remain compatible with other mods.
- Typically involve method prefixing or postfixing to alter or extend functionalities like modifying the calculation of carry capacities.
- Ensure Harmony patches are well-documented with comments clarifying the intention behind each patch.

## Suggestions for Copilot

- **Contextual Suggestions**: Given RimWorld's modding environment, Copilot can assist by suggesting methods for interacting with the game's core systems, notably in C#.
- **Code Completion**: Utilize Copilot for completing common RimWorld utility methods, type definitions, and method declarations.
- **Debugging Support**: Use Copilot to explore error messages quickly by suggesting common solutions or leading you to relevant documentation.
- **Harmony Examples**: Leverage Copilot for generating sample Harmony patches or identifying useful hooks (game methods) that are commonly modified in carry capacity mods.

By adhering to these guidelines and suggestions, contributors and developers can ensure a more seamless and consistent development experience using GitHub Copilot. The "[WZRD] Carry Capacity (Continued)" mod can thus be continually improved to meet the community's expectations for customizable gameplay.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

