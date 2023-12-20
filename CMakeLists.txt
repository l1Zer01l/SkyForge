cmake_minimum_required(VERSION 3.28 FATAL_ERROR)


set(PROPERTY_NAME SkyForge)
set(EXAMPLE_PROPERTY_NAME ExampleGame)

project(${PROPERTY_NAME} VERSION 0.0.1 LANGUAGES CSharp)

add_library(${PROPERTY_NAME} SHARED
	src/SkyForge/Core/Application.cs
	
)

add_executable(${EXAMPLE_PROPERTY_NAME}
	src/ExampleGame/game.cs
	
)

target_link_libraries(${EXAMPLE_PROPERTY_NAME} PRIVATE ${PROPERTY_NAME}) 

