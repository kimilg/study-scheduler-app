import React from "react";
import { Link } from "react-router-dom";
import { Button, Container, Divider, Header, Segment } from "semantic-ui-react";

export default function HomePage() {
    return (
        <Segment textAlign='center' vertical className='head'>
            <Container>
                <Header as='h1' inverted>
                    Welcome to Study Scheduler
                </Header>
                <Divider/>
                <Button as={Link} to='/details' size='huge' inverted>
                    Scheduler
                </Button>
            </Container>
        </Segment>
    )
}